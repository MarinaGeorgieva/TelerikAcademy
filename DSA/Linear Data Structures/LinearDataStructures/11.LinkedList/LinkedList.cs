namespace LinkedList
{
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        private ListItem<T> firstElement;

        public LinkedList()
        {
            this.FirstElement = null;
        }

        public ListItem<T> FirstElement
        {
            get { return this.firstElement; }
            set { this.firstElement = value; }
        }

        public void AddFirst(T value)
        {
            ListItem<T> newItem = new ListItem<T>(value);
            newItem.NextItem = this.FirstElement;
            this.FirstElement = newItem;
        }

        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newItem = this.FirstElement;
                while (newItem.NextItem != null)
                {
                    newItem = newItem.NextItem;
                }

                newItem.NextItem = new ListItem<T>(value);
            }            
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListItem<T> newItem = this.FirstElement;

            while (newItem != null)
            {
                yield return newItem.Value;
                newItem = newItem.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
