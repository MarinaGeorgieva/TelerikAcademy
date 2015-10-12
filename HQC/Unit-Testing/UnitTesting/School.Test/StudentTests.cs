namespace School.Test
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentShouldBeCorrectWithValidArguments()
        {
            var student = new Student("John", "Doe", 12345);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedId()
        {
            var student = new Student("John", "Doe", 12345);

            Assert.AreEqual(12345, student.Id);
        }

        [TestMethod]
        [ExpectedException(exceptionType: typeof(ArgumentNullException))]
        public void StudentShouldThrowIfFirstNameIsNull()
        {
            Student student = new Student(null, "Doe", 45345);
        }

        [TestMethod]
        [ExpectedException(exceptionType: typeof(ArgumentNullException))]
        public void StudentShouldThrowIfFirstNameIsEmpty()
        {
            Student student = new Student(string.Empty, "Doe", 21435);
        }

        [TestMethod]
        [ExpectedException(exceptionType: typeof(ArgumentNullException))]
        public void StudentShouldThrowIfLastNameIsNull()
        {
            Student student = new Student("John", null, 45365);
        }

        [TestMethod]
        [ExpectedException(exceptionType: typeof(ArgumentNullException))]
        public void StudentShouldThrowIfLastNameIsEmpty()
        {
            Student student = new Student("John", string.Empty, 12344);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentWithIdSmallerThanMinIdShouldThrow()
        {
            var student = new Student("John", "Doe", 434);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentWithIdBiggerThanMaxIdShouldThrow()
        {
            var student = new Student("John", "Doe", 150000);
        }

        [TestMethod]
        public void StudentShouldSignCourseCorrectly()
        {
            var student = new Student("John", "Doe", 12345);
            var course = new Course("C#");
            student.SignCourse(course);
            Assert.IsTrue(student.Courses.Contains(course));
            Assert.IsTrue(course.Students.Contains(student));
        }

        [TestMethod]
        public void StudentShouldUnsignCourseCorrectly()
        {
            var student = new Student("John", "Doe", 12345);
            var course = new Course("C#");
            student.SignCourse(course);
            Assert.IsTrue(student.Courses.Contains(course));
            student.UnsignCourse(course);
            Assert.IsFalse(student.Courses.Contains(course));
            Assert.IsFalse(course.Students.Contains(student));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenSigningNullCourse()
        {
            var student = new Student("John", "Doe", 12345);
            Course course = null;
            student.SignCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenUnsigningNullCourse()
        {
            var student = new Student("John", "Doe", 12345);
            Course course = null;
            student.UnsignCourse(course);
        }
    }
}
