namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using StudentSystem.Data;
    using StudentSystem.Models;
    using StudentSystem.Services.Models;

    public class HomeworksController : ApiController
    {
        private IStudentSystemData data;

        public HomeworksController() : this(new StudentSystemData())
        {
        }

        public HomeworksController(IStudentSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var homeworks = this.data.Homeworks.All().Select(HomeworkResponseModel.FromHomework);
            return this.Ok(homeworks);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var result = this.data.Homeworks
                .All()
                .Where(h => h.Id == id)
                .Select(HomeworkResponseModel.FromHomework)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post(HomeworkRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var homework = new Homework
            {
                Content = model.Content,
                Deadline = model.Deadline
            };

            this.data.Homeworks.Add(homework);
            this.data.Homeworks.SaveChanges();

            return this.Ok(homework);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, HomeworkRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var homework = this.data.Homeworks
                .All()
                .FirstOrDefault(h => h.Id == id);

            if (homework == null)
            {
                return this.BadRequest("Homework with id " + id + " does not exist!");
            }

            homework.Content = model.Content;
            homework.Deadline = model.Deadline;

            this.data.Homeworks.Update(homework);
            this.data.Homeworks.SaveChanges();

            return this.Ok(model);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var homework = this.data.Homeworks
                .All()
                .FirstOrDefault(h => h.Id == id);

            if (homework == null)
            {
                return this.BadRequest("Homework with id " + id + " does not exist!");
            }

            this.data.Homeworks.Delete(homework);
            this.data.Homeworks.SaveChanges();

            return this.Ok();
        }
    }
}