namespace MusicSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        public int Year { get; set; }

        public virtual Genre Genre { get; set; }

        public int? GenreId { get; set; }        

        public virtual Album Album { get; set; }

        public int? AlbumId { get; set; }
    }
}
