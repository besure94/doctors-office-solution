using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DoctorsOffice.Controllers
{
  public class DoctorsController : Controller
  {
    private readonly DoctorsOfficeContext _db;
    public DoctorsController(DoctorsOfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Doctor> model = _db.Doctors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Doctor doctor)
    {
      if (doctor.Name == null)
      {
        return RedirectToAction("Create");
      }
      else
      {
        _db.Doctors.Add(doctor);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      Doctor thisDoctor = _db.Doctors
      .Include(patient => patient.JoinEntities)
      .ThenInclude(doctor => doctor.Patient)
      .FirstOrDefault(doctor => doctor.DoctorId == id);
      return View(thisDoctor);
    }
  }
}