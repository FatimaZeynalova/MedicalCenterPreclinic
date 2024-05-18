using MedicalCenterPreclinic.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using System.Reflection.Emit;

namespace MedicalCenterPreclinic.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Specialization> Specializations { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("users");
            builder.Entity<IdentityRole>().ToTable("Roles");


            builder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BirthDate)
                    .IsRequired();

                entity.Property(e => e.AppointmentDate)
                    .IsRequired();

                entity.Property(e => e.AppointmentTime)
                    .IsRequired();

                entity.Property(e => e.Status);

            });
         }
    }
}
