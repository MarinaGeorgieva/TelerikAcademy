namespace Exceptions
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {            
            this.Score = score;
        }

        public int Score 
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < CSharpExam.MinScore || value > CSharpExam.MaxScore)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Score must be between {0} and {1}", CSharpExam.MinScore, CSharpExam.MaxScore));
                }

                this.score = value;
            }
        }        

        public override ExamResult Check()
        {
            if (this.Score < CSharpExam.MinScore || this.Score > CSharpExam.MaxScore)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
