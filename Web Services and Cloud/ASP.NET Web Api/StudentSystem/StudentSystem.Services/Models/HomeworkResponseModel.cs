namespace StudentSystem.Services.Models
{    
    using System;
    using System.Linq.Expressions;

    using StudentSystem.Models;

    public class HomeworkResponseModel
    {
        public static Expression<Func<Homework, HomeworkResponseModel>> FromHomework
        {
            get
            {
                return h => new HomeworkResponseModel
                {
                    Id = h.Id,
                    Content = h.Content,
                    Deadline = h.Deadline
                };
            }
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime Deadline { get; set; }
    }
}