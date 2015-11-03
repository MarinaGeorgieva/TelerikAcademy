namespace MusicSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using MusicSystem.Data;
    using MusicSystem.Models;
    using MusicSystem.Services.Models;

    public class ArtistsController : ApiController
    {
        private IMusicSystemData data;

        public ArtistsController() : this(new MusicSystemData())
        {
        }

        public ArtistsController(IMusicSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var artists = this.data.Artists
                .All()
                .Select(ArtistResponseModel.FromArtist);

            return this.Ok(artists);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var result = this.data.Artists
                .All()
                .Where(a => a.Id == id)
                .Select(ArtistResponseModel.FromArtist)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post(ArtistRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var artist = new Artist
            {
                Name = model.Name,
                DateOfBirth = model.DateOfBirth
            };

            this.data.Artists.Add(artist);
            this.data.Artists.SaveChanges();

            return this.Ok(artist);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, ArtistRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var artist = this.data.Artists
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (artist == null)
            {
                return this.BadRequest("Artist with id " + id + " does not exist!");
            }

            artist.Name = model.Name;
            artist.DateOfBirth = model.DateOfBirth;

            this.data.Artists.Update(artist);
            this.data.Artists.SaveChanges();

            return this.Ok(model);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var artist = this.data.Artists
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (artist == null)
            {
                return this.BadRequest("Artist with id " + id + " does not exist!");
            }

            this.data.Artists.Delete(artist);
            this.data.Artists.SaveChanges();

            return this.Ok();
        }
    }
}