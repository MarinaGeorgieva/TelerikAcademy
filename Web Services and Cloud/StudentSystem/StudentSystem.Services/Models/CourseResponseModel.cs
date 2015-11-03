namespace StudentSystem.Services.Models
{    
    using System;
    using System.Linq.Expressions;

    using StudentSystem.Models;

    public class CourseResponseModel
    {
        public static Expression<Func<Course, CourseResponseModel>> FromCourse
        {
            get
            {
                return c => new CourseResponseModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}