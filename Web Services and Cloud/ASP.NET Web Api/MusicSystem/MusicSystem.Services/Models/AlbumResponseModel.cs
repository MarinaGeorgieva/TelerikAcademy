namespace MusicSystem.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using MusicSystem.Models;

    public class AlbumResponseModel
    {
        public static Expression<Func<Album, AlbumResponseModel>> FromAlbum
        {
            get
            {
                return a => new AlbumResponseModel
                {
                    Title = a.Title,
                    Year = a.Year,
                    Producer = a.Producer,
                    Songs = a.Songs.Select(s => new SongResponseModel
                    {
                        Title = s.Title,
                        Year = s.Year,
                        Genre = s.Genre.Name
                    })
                };
            }
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public virtual IEnumerable<SongResponseModel> Songs { get; set; }
    }
}