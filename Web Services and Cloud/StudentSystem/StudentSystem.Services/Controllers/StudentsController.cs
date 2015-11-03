namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using StudentSystem.Data;
    using StudentSystem.Models;
    using StudentSystem.Services.Models;

    public class StudentsController : ApiController
    {
        private IStudentSystemData data;

        public StudentsController() : this(new StudentSystemData())
        {
        }

        public StudentsController(IStudentSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var students = this.data.Students.All().Select(StudentResponseModel.FromStudent);
            return this.Ok(students);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var result = this.data.Students
                .All()
                .Where(s => s.Id == id)
                .Select(StudentResponseModel.FromStudent)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post(StudentRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var student = new Student
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Number = model.Number
            };

            this.data.Students.Add(student);
            this.data.Students.SaveChanges();

            return this.Ok(student);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, StudentRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var student = this.data.Students
                .All()
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return this.BadRequest("Student with id " + id + " does not exist!");
            }

            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Age = model.Age;
            student.Number = model.Number;

            this.data.Students.Update(student);
            this.data.Students.SaveChanges();

            return this.Ok(model);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var student = this.data.Students
                .All()
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return this.BadRequest("Student with id " + id + " does not exist!");
            }

            this.data.Students.Delete(student);
            this.data.Students.SaveChanges();

            return this.Ok();
        }
    }
}