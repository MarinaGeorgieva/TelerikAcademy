﻿namespace Exceptions
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        { 
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade 
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grade must be positive number or zero");
                }

                this.grade = value;
            }
        }

        public int MinGrade 
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Min grade must be a positive number or 0");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade 
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentException("Max grade must be a positive number and greater than min grade");
                }

                this.maxGrade = value;
            }
        }

        public string Comments 
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Comments cannot be null or empty");
                }

                this.comments = value;
            }
        }
    }
}
