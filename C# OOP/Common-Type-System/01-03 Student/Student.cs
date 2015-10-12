namespace _01_03_Student
{
    using System;

    public enum Specialties
    {
        SoftwareEngineering,
        ComputerScience,
        Law,
        PublicRelations,
        Pharmacist,
        AppliedPhysics,
    }

    public enum Faculties
    {
        FMI,
        FHF,
        FF,
        UF,
    }

    public enum Universities
    {
        SU,
        TU,
        UNSS,
        NBU,
    }

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialties Specialty { get; set; }
        public Faculties Faculty { get; set; }
        public Universities University { get; set; }

        public Student(string firstName, string middleName, string lastName, ulong ssn, 
            string address, string phone, string email, int course,
            Specialties specialty, Faculties faculty, Universities university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public object Clone()
        {
            Student other = new Student(this.FirstName, this.MiddleName, this.LastName,
                this.SSN, this.Address, this.Phone, this.Email, this.Course,
                this.Specialty, this.Faculty, this.University);

            return other;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.SSN.CompareTo(other.SSN) != 0)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (this.FirstName == student.FirstName &&
                this.MiddleName == student.MiddleName &&
                this.LastName == student.LastName &&
                this.SSN == student.SSN &&
                this.Address == student.Address &&
                this.Phone == student.Phone &&
                this.Email == student.Email &&
                this.Course == student.Course &&
                this.Specialty == student.Specialty &&
                this.Faculty == student.Faculty &&
                this.University == student.University)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.FirstName.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2} \nSSN: {3} \nAddress: {4} \nPhone: {5} \nE-mail: {6} \nCourse: {7}" +
                "\nSpecialty: {8} \nFaculty: {9} \nUniversity: {10} \n", 
                this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.Phone, this.Email, this.Course,
                this.Specialty, this.Faculty, this.University);
        }        
    }
}
