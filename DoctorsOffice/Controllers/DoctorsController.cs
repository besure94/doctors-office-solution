using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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
      List<Doctor> model = _db.Doctors
      .Include(patient => patient.JoinEntities)
      .ThenInclude(doctor => doctor.Patient)
      .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.SpecialtyId = new SelectList(_db.Specialties, "SpecialtyId", "Title");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Doctor doctor, int specialtyId)
    {
      if (doctor.Name == null || specialtyId == 0)
      {
        return RedirectToAction("Create");
      }
      else
      {
        _db.Doctors.Add(doctor);
        _db.SaveChanges();
        _db.DoctorSpecialties.Add(new DoctorSpecialty() { SpecialtyId = specialtyId, DoctorId = doctor.DoctorId });
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
      Doctor thisDoctorsSpecialties = _db.Doctors
      .Include(specialty => specialty.JoinClasses)
      .ThenInclude(doctor => doctor.Specialty)
      .FirstOrDefault(doctor => doctor.DoctorId == id);
      return View(thisDoctor);
    }

  }
}