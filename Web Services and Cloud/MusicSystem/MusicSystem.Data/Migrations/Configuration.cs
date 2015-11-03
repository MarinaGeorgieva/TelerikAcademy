namespace MusicSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    using MusicSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<MusicSystemDbContext>
    {
        public Configuration()
        {           
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MusicSystemDbContext context)
        {  
            var artist = new Artist
            {
                Name = "Eminem",
                DateOfBirth = new DateTime(1972, 10, 17)
            };

            var album = new Album
            {
                Title = "The Marshall Mathers LP",
                Year = 2000,
                Producer = "Dr.Dre"
            };           

            var country = new Country { Name = "USA" };

            var songs = new List<Song>
            {
                new Song
                {
                    Title = "The Way I Am",
                    Year = 2000
                },
                new Song
                {
                    Title = "The Real Slim Shady",
                    Year = 2000
                }
            };

            var genre = new Genre { Name = "Hip Hop" };

            songs.ForEach(s => genre.Songs.Add(s));
            songs.ForEach(s => album.Songs.Add(s));
            artist.Albums.Add(album);
            country.Artists.Add(artist);

            context.Genres.Add(genre);
            songs.ForEach(song => context.Songs.Add(song));
            context.Albums.Add(album);
            context.Artists.Add(artist);
            context.Countries.Add(country);            
        }
    }
}
