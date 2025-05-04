namespace ClinicApp2.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int DepartmentId {  get; set; }
        public Department Department { get; set; }
    }
}
