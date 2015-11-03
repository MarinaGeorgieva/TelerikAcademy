namespace MusicSystem.Services.Models
{
    using System;
    using System.Linq.Expressions;

    using MusicSystem.Models;

    public class SongResponseModel
    {
        public static Expression<Func<Song, SongResponseModel>> FromSong
        {
            get
            {
                return s => new SongResponseModel
                {
                    Title = s.Title,
                    Year = s.Year,
                    Genre = s.Genre.Name
                };
            }
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }
    }
}