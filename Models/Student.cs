using System.ComponentModel.DataAnnotations;

namespace ChoirManager.Models

{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public required string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public required string LastName { get; set; }        
        public int Grade { get; set; }

        [Display(Name = "Parent First Name")]
        public required string ParentFirstName { get; set; }
        
        [Display(Name = "Parent Last Name")]

        public required string ParentLastName { get; set; }
        public required string Address { get; set; }
        [Display(Name = "Phone Number")]

        public required string PhoneNumber { get; set; }
        public bool WantsSolos { get; set; }
    }
}