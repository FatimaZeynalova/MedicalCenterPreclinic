using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalCenterPreclinic.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string? BirthOfDate { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }


        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }

        public string? Institution { get; set; }
        public string? Subject { get; set; }

        public string? StartingDate { get; set; }
        public string? CompleteDate { get; set; }
        public string? Degree { get; set; }

        public string? Grade { get; set; }
        public string? CompanyName { get; set; }
        public string? Location { get; set; }

        public string? JobPosition { get; set; }
        public string? PeriodFrom { get; set; }
        public string? PeriodTo { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Specialization Specialization { get; set; }

        public List<Appointment> Appointments {  get; set; }   
        public int SpecializationId { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }

}
