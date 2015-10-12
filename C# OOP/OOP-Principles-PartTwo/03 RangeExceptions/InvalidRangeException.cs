using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException 
        where T : IComparable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end, Exception innerEx)
            : base(message, innerEx)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }
    }
}
