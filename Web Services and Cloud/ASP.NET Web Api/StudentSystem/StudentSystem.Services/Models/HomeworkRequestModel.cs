namespace StudentSystem.Services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class HomeworkRequestModel
    {
        [Required]
        [MaxLength(150)]
        public string Content { get; set; }

        [Required]
        public DateTime Deadline { get; set; }
    }
}