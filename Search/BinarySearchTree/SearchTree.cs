using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Search.BinarySearchTree
{
    internal class SearchTree<T>
    {
        public TreeNode<T>? Root { get; set; }

        public void Insert(int key, T value)
        {
            Root = InsertItem(Root, key, value);
        }

        public void PrintBinaryTree()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
            PreOrderTraversal(Root);
            Console.WriteLine();
            PostOrderTraversal(Root);
            Console.WriteLine();
        }

        private void PostOrderTraversal(TreeNode<T>? node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.LeftChild);
                PostOrderTraversal(node.RightChild);
                Console.WriteLine($"{node.Key} {node.Value}");
            }
        }

        private void PreOrderTraversal(TreeNode<T>? node)
        {
            if (node != null)
            {
                Console.WriteLine($"{node.Key} {node.Value}");
                PreOrderTraversal(node.LeftChild);
                PreOrderTraversal(node.RightChild);
            }
        }

        private void InOrderTraversal(TreeNode<T>? node)
        {
            if(node != null)
            {
                InOrderTraversal(node.LeftChild);
                Console.WriteLine($"{node.Key} {node.Value}");
                InOrderTraversal(node.RightChild);
            }
        }

        private TreeNode<T> InsertItem(TreeNode<T>? node, int key, T value)
        {
            var newNode = new TreeNode<T>(key, value);

            // if this is the first time, insert is called, then create the Root
            if (node == null)
            {
                return node = newNode;
                
            }

            // if this is not the first insert, then traverse and find the null
            if (key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }

            return node;
        }
    }
}
