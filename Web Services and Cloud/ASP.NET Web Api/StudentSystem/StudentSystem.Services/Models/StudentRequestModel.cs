namespace StudentSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class StudentRequestModel
    {
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        [Range(10000, 99999)]
        public int Number { get; set; }

        [Required]
        [Range(16, 100)]
        public int Age { get; set; }
    }
}