namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using StudentSystem.Data;
    using StudentSystem.Models;
    using StudentSystem.Services.Models;

    public class CoursesController : ApiController
    {
        private IStudentSystemData data;

        public CoursesController() : this(new StudentSystemData())
        {
        }

        public CoursesController(IStudentSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var courses = this.data.Courses.All().Select(CourseResponseModel.FromCourse);
            return this.Ok(courses);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var result = this.data.Courses
                .All()
                .Where(c => c.Id == id)
                .Select(CourseResponseModel.FromCourse)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post(CourseRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var course = new Course
            {
                Name = model.Name,
                Description = model.Description
            };

            this.data.Courses.Add(course);
            this.data.Courses.SaveChanges();

            return this.Ok(course);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, CourseRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var course = this.data.Courses
                .All()
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return this.BadRequest("Course with id " + id + " does not exist!");
            }

            course.Name = model.Name;
            course.Description = model.Description;

            this.data.Courses.Update(course);
            this.data.Courses.SaveChanges();

            return this.Ok(model);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var course = this.data.Courses
                .All()
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return this.BadRequest("Course with id " + id + " does not exist!");
            }

            this.data.Courses.Delete(course);
            this.data.Courses.SaveChanges();

            return this.Ok();
        }
    }
}