using Microsoft.EntityFrameworkCore;

namespace DoctorsOffice.Models
{
  public class DoctorsOfficeContext : DbContext
  {
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
    public DbSet<DoctorPatient> DoctorPatients { get; set; }
    public DoctorsOfficeContext(DbContextOptions options) : base (options) { }
  }
}