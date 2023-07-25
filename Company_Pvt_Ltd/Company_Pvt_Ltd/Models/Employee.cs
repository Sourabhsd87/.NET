
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Company_Pvt_Ltd.Models
{
    [Index(nameof(email),IsUnique = true)]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a valid Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a valid salary")]
        public double salary { get; set; }

        [Required(ErrorMessage = "Please enter a valid Email")]
        [EmailAddress]
        public string? email { get; set; }
        [Required(ErrorMessage = "Please enter a valid password")]
        [PasswordPropertyText]
        public string? password { get; set; }
        [Required(ErrorMessage = "Please enter a valid Joindate")]

        public DateOnly joindate { get; set; }
    }
}
