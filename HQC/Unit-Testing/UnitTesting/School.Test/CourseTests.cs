namespace School.Test
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;    

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseShoulReturnNameCorrectly()
        {
            var course = new Course("C#");
            Assert.AreEqual("C#", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseWithNullNameShouldThrow()
        {
            var course = new Course(null);
        }        

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseWithEmptyNameShouldThrow()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void CourseShouldAddStudentCorrectly()
        {
            var course = new Course("C#");
            var student = new Student("John", "Doe", 10000);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowWhenNullStudentAdded()
        {
            var course = new Course("C#");
            Student student = null;
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowWhenExistingStudentAdded()
        {
            var course = new Course("C#");
            Student student = new Student("John", "Doe", 10000);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseShouldThrowWhenMoreThanMaxStudentsAdded()
        {
            var course = new Course("C#");

            for (int i = 0; i < 40; i++)
            {
                course.AddStudent(new Student(i.ToString(), i.ToString(), 10000 + i));
            }
        }

        [TestMethod]
        public void CourseShouldRemoveStudentCorrectly()
        {
            var course = new Course("C#");
            var student = new Student("John", "Doe", 12345);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowWhenRemovingNullStudent()
        {
            var course = new Course("C#");
            Student student = null;
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowWhenRemovingUnsignedStudent()
        {
            var course = new Course("C#");
            Student student = new Student("John", "Doe", 10000);
            course.RemoveStudent(student);
        }
    }
}
