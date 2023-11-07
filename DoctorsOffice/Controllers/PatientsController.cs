using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http.Features;

namespace DoctorsOffice.Controllers
{
  public class PatientsController : Controller
  {
    private readonly DoctorsOfficeContext _db;
    public PatientsController(DoctorsOfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Patient> model = _db.Patients.Include(patient => patient.Doctor).ToList();
      ViewBag.PageTitle = "View all patients";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create (Patient patient)
    {
      if (patient.DoctorId == 0 || patient.Name == null)
      {
        return RedirectToAction("Create");
      }
      _db.Patients.Add(patient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Patient thisPatient = _db.Patients
        .Include(patient => patient.JoinEntities)
        .ThenInclude(patient => patient.Doctor)
        .FirstOrDefault(patient => patient.PatientId == id);
      return View(thisPatient);
    }

    public ActionResult AddDoctor(int id)
    {
      Patient thisPatient = _db.Patients.FirstOrDefault(patients => patients.PatientId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View(thisPatient);
    }

    [HttpPost]
    public ActionResult AddDoctor(Patient patient, int doctorId)
    {
      #nullable enable
      DoctorPatient? joinEntity = _db.DoctorPatient.FirstOrDefault(join => (join.DoctorPatientId == doctorId && join.PatientId == patient.PatientId));
      #nullable disable
      if (joinEntity == null && doctorId != 0)
      {
        _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = doctorId, PatientId = patient.PatientId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = patient.PatientId });
    }
  }
}