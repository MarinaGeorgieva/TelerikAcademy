namespace MusicSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using MusicSystem.Data;
    using MusicSystem.Models;
    using MusicSystem.Services.Models;

    public class AlbumsController : ApiController
    {
        private IMusicSystemData data;

        public AlbumsController() : this(new MusicSystemData())
        {
        }

        public AlbumsController(IMusicSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var albums = this.data.Albums
                .All()
                .Select(AlbumResponseModel.FromAlbum);

            return this.Ok(albums);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var result = this.data.Albums
                .All()
                .Where(a => a.Id == id)
                .Select(AlbumResponseModel.FromAlbum)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post(AlbumRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var album = new Album
            {
                Title = model.Title,
                Year = model.Year,
                Producer = model.Producer
            };

            this.data.Albums.Add(album);
            this.data.Albums.SaveChanges();

            return this.Ok(album);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, AlbumRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var album = this.data.Albums
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (album == null)
            {
                return this.BadRequest("Album with id " + id + " does not exist!");
            }

            album.Title = model.Title;
            album.Year = model.Year;
            album.Producer = model.Producer;

            this.data.Albums.Update(album);
            this.data.Albums.SaveChanges();

            return this.Ok(model);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var albums = this.data.Albums
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (albums == null)
            {
                return this.BadRequest("Album with id " + id + " does not exist!");
            }

            this.data.Albums.Delete(albums);
            this.data.Albums.SaveChanges();

            return this.Ok();
        }
    }
}