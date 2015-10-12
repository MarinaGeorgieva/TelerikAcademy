

namespace _09_16_Problems
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private List<double> marks;
        private Group groupN;

        public Student(string firstName, string lastName, string fn, string tel, string email, List<double> marks, Group groupN)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupN = groupN;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("First name cannot be null or empty string");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Last name cannot be null or empty string");
                }

                this.lastName = value;
            }
        }

        public string FN
        {
            get
            {
                return this.fn;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Faculty number cannot be null or empty");
                }

                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Phone number cannot be null or empty");
                }

                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("E-mail cannot be null or empty");
                }

                this.email = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public Group GroupN
        {
            get
            {
                return this.groupN;
            }
            set
            { 
                this.groupN = value;
            }
        }

        private string MarksToString()
        {
            StringBuilder result = new StringBuilder();
            int counter = -1;

            foreach (double mark in Marks)
            {
                counter++;
                result.Append(mark);

                if (counter != Marks.Count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        public override string ToString()
        {
            return string.Format("Full name: {0} {1} \nFaculty number: {2} \nTel: {3} \nE-mail: {4} \nMarks: {5} \nGroup number: {6} \nDepartment number: {7}\n", 
                this.FirstName, this.LastName, this.FN, this.Tel, this.Email, MarksToString(), this.GroupN.GroupNumber, this.GroupN.DepartmentNumber);
        }
    }
}
