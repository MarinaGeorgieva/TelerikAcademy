namespace MusicSystem.Data
{
    using System.Data.Entity;

    using MusicSystem.Data.Migrations;
    using MusicSystem.Models;    

    public class MusicSystemDbContext : DbContext
    {
        public MusicSystemDbContext() : base("MusicSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicSystemDbContext, Configuration>());
        }

        public virtual IDbSet<Album> Albums { get; set; }
               
        public virtual IDbSet<Artist> Artists { get; set; }
               
        public virtual IDbSet<Song> Songs { get; set; }
               
        public virtual IDbSet<Genre> Genres { get; set; }        
               
        public virtual IDbSet<Country> Countries { get; set; }
    }
}
