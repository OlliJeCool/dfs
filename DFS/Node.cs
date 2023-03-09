using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>>? Neighbors { get; set; } = new List<Node<T>> { };
    }
}
