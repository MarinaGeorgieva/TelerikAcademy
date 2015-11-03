namespace MusicSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using MusicSystem.Data;
    using MusicSystem.Models;
    using MusicSystem.Services.Models;

    public class SongsController : ApiController
    {
        private IMusicSystemData data;

        public SongsController() : this(new MusicSystemData())
        {
        }

        public SongsController(IMusicSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var songs = this.data.Songs
                .All()
                .Select(SongResponseModel.FromSong);

            return this.Ok(songs);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var result = this.data.Songs
                .All()
                .Where(s => s.Id == id)
                .Select(SongResponseModel.FromSong)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post(SongRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var song = new Song
            {
                Title = model.Title,
                Year = model.Year
            };

            this.data.Songs.Add(song);
            this.data.Songs.SaveChanges();

            return this.Ok(song);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, SongRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var song = this.data.Songs
                .All()
                .FirstOrDefault(s => s.Id == id);

            if (song == null)
            {
                return this.BadRequest("Song with id " + id + " does not exist!");
            }

            song.Title = model.Title;
            song.Year = model.Year;

            this.data.Songs.Update(song);
            this.data.Songs.SaveChanges();

            return this.Ok(model);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var song = this.data.Songs
                .All()
                .FirstOrDefault(s => s.Id == id);

            if (song == null)
            {
                return this.BadRequest("Song with id " + id + " does not exist!");
            }

            this.data.Songs.Delete(song);
            this.data.Songs.SaveChanges();

            return this.Ok();
        }
    }
}