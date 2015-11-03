namespace StudentSystem.Services.Models
{
    using System;
    using System.Linq.Expressions;

    using StudentSystem.Models;

    public class StudentResponseModel
    {
        public static Expression<Func<Student, StudentResponseModel>> FromStudent
        {
            get
            {
                return s => new StudentResponseModel
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Age = s.Age,
                    Number = s.Number
                };
            }
        }

        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int Number { get; set; }
    }
}