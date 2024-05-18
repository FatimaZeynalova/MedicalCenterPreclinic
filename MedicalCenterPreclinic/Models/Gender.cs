namespace MedicalCenterPreclinic.Models
{
	public class Gender
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Parients { get; set; }


    }
}
