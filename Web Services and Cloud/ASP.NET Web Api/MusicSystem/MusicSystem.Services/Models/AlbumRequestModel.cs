namespace MusicSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AlbumRequestModel
    {
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public string Producer { get; set; }
    }
}