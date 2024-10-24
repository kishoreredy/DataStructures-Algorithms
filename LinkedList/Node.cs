﻿namespace LinkedList
{
    internal class Node<T>
    {
        public required T Data { get; set; }
        public Node<T>? Next { get; set; }

        public void DisplayData()
        {
            Console.WriteLine(Data?.ToString());
        }
    }
}
