namespace _09_16_Problems
{
    using System;

    public class Group
    {
        private int groupNumber;
        private string departmentNumber;

        public Group(int groupNumber, string departmentNumber)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentNumber = departmentNumber;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group number must be positive");
                }

                this.groupNumber = value;
            }
        }

        public string DepartmentNumber
        {
            get
            {
                return this.departmentNumber;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Department number cannnot be null or empty");
                }

                this.departmentNumber = value;
            }
        }
    }
}
