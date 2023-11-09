using System.Collections.Generic;
using System;

namespace DoctorsOffice.Models
{
  public class Specialty
  {
    public int SpecialtyId { get; set; }
    public string Title { get; set; }
    public List<DoctorSpecialty> JoinClasses { get; }

  }
}