namespace MusicSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SongRequestModel
    {
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        public int Year { get; set; }
    }
}