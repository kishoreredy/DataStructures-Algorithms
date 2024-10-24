using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.BinarySearchTree
{
    internal class TreeNode<T>(int key, T value)
    {
        public int Key { get; set; } = key;
        public T Value { get; set; } = value;
        public TreeNode<T>? LeftChild { get; set; }
        public TreeNode<T>? RightChild { get; set; }
    }
}
