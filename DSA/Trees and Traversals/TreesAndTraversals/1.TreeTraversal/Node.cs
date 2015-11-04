namespace _1.TreeTraversal
{
    using System.Collections.Generic;

    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
            this.Children = new List<Node<T>>();
            this.HasParent = false;
        }

        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }

        public bool HasChildren
        {
            get
            {
                return this.Children.Count > 0;
            }
        }

        public void AddChild(Node<T> child)
        {
            this.Children.Add(child);
            child.HasParent = true;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
