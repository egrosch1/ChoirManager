namespace ChoirManager.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Grade { get; set; }
        public required string ParentFirstName { get; set; }
        public required string ParentLastName { get; set; }
        public required string Address { get; set; }
        public required string PhoneNumber { get; set; }
        public bool WantsSolos { get; set; }
    }
}