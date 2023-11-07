using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http.Features;

namespace DoctorsOffice.Controllers
{
  public class SpecialtiesController : Controller
  {
    private readonly DoctorsOfficeContext _db;
    public SpecialtiesController(DoctorsOfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Specialty> model = _db.Specialties.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Specialty specialty)
    {
      if (specialty.Title == null)
      {
        return RedirectToAction("Create");
      }
      else
      {
        // specialty.DoctorId = 0;
        _db.Specialties.Add(specialty);
        _db.SaveChanges();
        // _db.DoctorSpecialties.Add(new DoctorSpecialty() { DoctorId = specialty.DoctorId, SpecialtyId = specialty.SpecialtyId });
        return RedirectToAction("Index");
      }
    }
  }
}