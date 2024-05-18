namespace MedicalCenterPreclinic.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
