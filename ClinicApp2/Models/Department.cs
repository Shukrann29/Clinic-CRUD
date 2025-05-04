namespace ClinicApp2.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public ICollection<Doctor>DoctorList { get; set; }
    }
}
