using System.Collections.Generic;
using System;

namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public int DoctorId { get; set; }
    public string Name { get; set; }
    // public string Specialty { get; set; }
    public List<Patient> Patients { get; set; }
    public List<Specialty> Specialties { get; set; }
    public List<DoctorPatient> JoinEntities { get; }
    public List<DoctorSpecialty> JoinClasses { get; }
  }
}