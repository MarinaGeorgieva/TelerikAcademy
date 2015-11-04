namespace _1.TreeTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var nodes = ReadAndParseInput();

            var root = FindRootNode(nodes);
            Console.WriteLine("Root: " + root);

            var leaves = FindAllLeafNodes(nodes);
            Console.WriteLine("Leaves: " + string.Join(", ", leaves));

            var middleNodes = FindAllMiddleNodes(nodes);
            Console.WriteLine("Middle nodes: " + string.Join(", ", middleNodes));

            var longestPath = FindLongestPath(nodes);
            Console.WriteLine("Longest path: " + longestPath);
        }

        private static int FindLongestPath(List<Node<int>> nodes)
        {
            var stack = new Stack<Node<int>>();
            var path = 0;
            var longestPath = 0;
            var root = FindRootNode(nodes);
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (!node.HasChildren)
                {
                    if (path > longestPath)
                    {
                        longestPath = path;
                    }

                    continue;
                }

                path++;

                foreach (var child in node.Children)
                {
                    stack.Push(child);
                }
            }

            return longestPath;
        }

        private static List<Node<int>> FindAllMiddleNodes(List<Node<int>> nodes)
        {
            var middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasChildren && node.HasParent)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static List<Node<int>> FindAllLeafNodes(List<Node<int>> nodes)
        {
            var leaves = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (!node.HasChildren)
                {
                    leaves.Add(node);
                }
            }

            if (leaves.Count == 0)
            {
                throw new ArgumentException("The tree does not have any leaves!");
            }

            return leaves;
        }

        private static Node<int> FindRootNode(List<Node<int>> nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.HasParent)
                {
                    return node;
                }
            }

            throw new ArgumentException("The tree does not have a root!");
        }

        private static List<Node<int>> ReadAndParseInput()
        {
            var nodes = new List<Node<int>>();

            int n = int.Parse(Console.ReadLine());            

            for (int i = 0; i < n - 1; i++)
            {
                int[] values = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(v => int.Parse(v))
                    .ToArray();
                int parentValue = values[0];
                int childValue = values[1];

                var parent = nodes.FirstOrDefault(x => x.Value == parentValue);
                var child = nodes.FirstOrDefault(x => x.Value == childValue);
                
                if (parent == null)
                {
                    parent = new Node<int>(parentValue);
                    nodes.Add(parent);
                }   
                
                if (child == null)
                {
                    child = new Node<int>(childValue);
                    nodes.Add(child);
                }

                parent.AddChild(child);         
            }

            return nodes;         
        }
    }
}
