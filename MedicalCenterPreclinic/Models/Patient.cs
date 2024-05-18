namespace MedicalCenterPreclinic.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string BirthOfDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
