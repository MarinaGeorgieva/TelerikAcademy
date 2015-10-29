namespace LinkedList
{
    public class ListItem<T>
    {
        private T value;
        private ListItem<T> nextItem;

        public ListItem(T value) : this(value, null)
        {
        }

        public ListItem(T value, ListItem<T> nextItem)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public ListItem<T> NextItem
        {
            get { return this.nextItem; }
            set { this.nextItem = value; }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
