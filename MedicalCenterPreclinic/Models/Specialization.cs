using MedicalCenterPreclinic.Models;

namespace MedicalCenterPreclinic.Models
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool İsDeleted { get; set; }
        public List<Doctor> Doctors { get; set; }


    }
}
