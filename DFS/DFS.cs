using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class DFS
    {
        public List<Node<int>>? visited;

        public void Run(Node<int> node)
        {
            if (visited != null) visited.Clear();
            visited = new List<Node<int>>();


            if (!visited.Contains(node))
            {

                if (node.Neighbors.Count > 0)
                {
                    Console.Write($"{node.Value} => ");
                    node.Neighbors.ForEach(x =>
                    {
                        Console.Write(x.Value + " ");
                    });
                    Console.WriteLine();
                    for (int i = 0; i <= node.Neighbors.Count - 1; i++)
                    {
                        Run(node.Neighbors[i]);
                    }

                }
                else if (node.Neighbors.Count == 0) Console.WriteLine($"{node.Value} => -");
                visited.Add(node);
            }

            return;
        }


        public Node<int> Init()
        {
            var eight = new Node<int> { Value = 8 };
            var six = new Node<int> { Value = 6, Neighbors = { eight } };
            var five = new Node<int> { Value = 5 };
            var four = new Node<int> { Value = 4 };
            var two = new Node<int> { Value = 2, Neighbors = { four, five, six } };
            var nine = new Node<int> { Value = 9 };
            var seven = new Node<int> { Value = 7, Neighbors = { nine } };
            var three = new Node<int> { Value = 3, Neighbors = { seven } };
            var head = new Node<int> { Value = 1, Neighbors = { two, three } };

            return head;
        }
    }
}
