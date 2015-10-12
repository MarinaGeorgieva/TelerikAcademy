namespace _05_64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException();
                }

                return (int)((this.Number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value");
                }

                if (value == 0)
                {
                    this.Number = this.Number & (~((ulong)1 << pos));
                }
                else
                {
                    this.Number = this.Number | ((ulong)1 << pos);
                }
            }
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;

            if (bitArray == null)
            {
                return false;
            }

            if (this.Number != bitArray.Number)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int pos = 0; pos < 64; pos++)
            {
                if (((this.Number >> (63 - pos)) & 1) == 0)
                {
                    result.Append(0);
                }
                else
                {
                    result.Append(1);
                }
            }

            return result.ToString();
        }
    }
}
