namespace MusicSystem.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using MusicSystem.Models;

    public class ArtistResponseModel
    {
        public static Expression<Func<Artist, ArtistResponseModel>> FromArtist
        {
            get
            {
                return a => new ArtistResponseModel
                {
                    Name = a.Name,
                    DateOfBirth = a.DateOfBirth,
                    Country = a.Country.Name,
                    Albums = a.Albums.Select(al => new AlbumResponseModel
                    {
                        Title = al.Title,
                        Year = al.Year,
                        Producer = al.Producer,
                        Songs = al.Songs.Select(s => new SongResponseModel
                        {
                            Title = s.Title,
                            Year = s.Year,
                            Genre = s.Genre.Name
                        })
                    })
                };
            }
        }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Country { get; set; }

        public IEnumerable<AlbumResponseModel> Albums { get; set; }
    }
}