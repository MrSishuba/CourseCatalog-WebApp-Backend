using System.ComponentModel.DataAnnotations;

namespace u20649232_HW01_API.Models
{
    public class CourseListing
    {
        [Key]
        public int courseId { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "The course name cannot be longer than 6 characters.")]
        public string?  courseName { get; set; }

        [Required]      
        public string? courseDuration { get; set; }

        [Required]
        public string?  courseDescription { get; set; }
    }
}
