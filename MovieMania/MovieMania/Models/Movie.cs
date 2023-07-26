using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    [Index(nameof(movieName))]

    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter a valid name")]
        public string movieName { get; set; }
        [Required(ErrorMessage = "Enter a valid Producer name")]
        public string producer { get; set; }
        [Required(ErrorMessage = "Enter a valid ticket price")]
        public double ticket { get; set; }
        [Required(ErrorMessage = "Enter a valid release date")]
        public DateOnly releaseDate { get; set; }
    }
}
