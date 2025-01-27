using System.ComponentModel.DataAnnotations;

namespace MyFirstProject_AppWeb_Net.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string name { get; set; }

        [Range(16, 60, ErrorMessage = "Ages 16-60 only")]
        public int age { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid, enter like # or #.##")]
        public decimal salary { get; set; }

        public string department { get; set; }

        [RegularExpression(@"^[MF]+$", ErrorMessage = "Select any one option")]
        public string sex { get; set; }
    }
}
