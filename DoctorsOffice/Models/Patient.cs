using System.Collections.Generic;
using System;

namespace DoctorsOffice.Models
{
  public class Patient
  {
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
    public Doctor Doctor { get; set; }
    public List<DoctorPatient> JoinEntities { get; }

  }
}