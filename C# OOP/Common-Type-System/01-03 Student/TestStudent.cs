/* Problem 1. Student class

Define a class Student, which contains data about a student – first, middle and last name, SSN, 
permanent address, mobile phone e-mail, course, specialty, university, faculty. 
Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 
Problem 2. IClonable

Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields 
into a new object of type Student.
 * 
Problem 3. IComparable

Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
and by social security number (as second criteria, in increasing order).
*/

namespace _01_03_Student
{
    using System;

    public class TestStudent
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Ivan", "Georgiev", "Petrov", 543943113, "Sofia", "+359854332356",
                "vankata@abv.bg", 3, Specialties.ComputerScience, Faculties.FMI, Universities.SU);

            Student secondStudent = new Student("Todor", "Dimitrov", "Hristov", 7643265123, "Sofia", "+359834651209",
                "todor@abv.bg", 3, Specialties.ComputerScience, Faculties.FMI, Universities.SU);

            Console.WriteLine(firstStudent);
            Console.WriteLine(secondStudent);

            Console.WriteLine(firstStudent.GetHashCode());
            Console.WriteLine(secondStudent.GetHashCode());
            Console.WriteLine();

            Console.WriteLine(firstStudent.Equals(secondStudent));
            Console.WriteLine(firstStudent == secondStudent);
            Console.WriteLine(firstStudent != secondStudent);
            Console.WriteLine();

            Student studentClone = (Student)firstStudent.Clone();
            Console.WriteLine(firstStudent.Equals(studentClone));
            Console.WriteLine(firstStudent == studentClone);
            Console.WriteLine(firstStudent != studentClone);
            Console.WriteLine();
        }
    }
}
