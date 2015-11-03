namespace MusicSystem.Services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ArtistRequestModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}