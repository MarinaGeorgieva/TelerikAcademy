namespace MusicSystem.Data
{
    using MusicSystem.Data.Repositories;
    using MusicSystem.Models;

    public interface IMusicSystemData
    {
        IRepository<Album> Albums { get; }

        IRepository<Artist> Artists { get; }

        IRepository<Song> Songs { get; }        

        IRepository<Genre> Genres { get; }

        IRepository<Country> Countries { get; }

        int Savechanges();
    }
}
