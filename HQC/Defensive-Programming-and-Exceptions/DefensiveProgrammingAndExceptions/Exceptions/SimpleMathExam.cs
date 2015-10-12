namespace Exceptions
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;
        private const int BadGradeProblemsSolved = 0;
        private const int AverageGradeProblemsSolved = 1;
        private const int ExcellentGradeProblemsSolved = 2;
        private const string BadGradeComment = "Bad result: nothing done.";
        private const string AverageGradeComment = "Average result: almost everything done.";
        private const string ExcellentGradeComment = "Excellent result: everything done.";
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {   
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved 
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < SimpleMathExam.MinProblemsSolved)
                {
                    value = SimpleMathExam.MinProblemsSolved;
                }

                if (value > SimpleMathExam.MaxProblemsSolved)
                {
                    value = SimpleMathExam.MaxProblemsSolved;
                }

                this.problemsSolved = value;
            } 
        }        

        public override ExamResult Check()
        {
            string comment = string.Empty;

            if (this.ProblemsSolved == SimpleMathExam.BadGradeProblemsSolved)
            {
                comment = SimpleMathExam.BadGradeComment;
            }
            else if (this.ProblemsSolved == SimpleMathExam.AverageGradeProblemsSolved)
            {
                comment = SimpleMathExam.AverageGradeComment;
            }
            else if (this.ProblemsSolved == SimpleMathExam.ExcellentGradeProblemsSolved)
            {
                comment = SimpleMathExam.ExcellentGradeComment;
            }

            return new ExamResult(this.ProblemsSolved, SimpleMathExam.MinProblemsSolved, SimpleMathExam.MaxProblemsSolved, comment);
        }
    }
}
