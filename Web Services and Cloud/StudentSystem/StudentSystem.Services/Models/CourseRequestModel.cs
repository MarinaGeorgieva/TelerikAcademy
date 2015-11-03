namespace StudentSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CourseRequestModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
    }
}