namespace LinkedList
{
    internal class CustomLinkedList<T>
    {
        public Node<T>? First { get; set; }
        public void InsertFirst(T item)
        {
            Node<T> newNode = new Node<T> { Data = item };
            newNode.Next = First;
            First = newNode;
        }

        public Node<T>? DeleteFirst()
        {
            if(First?.Next == null)
            {
                Console.WriteLine("There is only one element");
                return null;
            }
            return First = First.Next;
        }

        public void DisplayList()
        {
            Node<T>? current = First;
            while (current != null)
            {
                current.DisplayData();
                current = current.Next;
            }
        }

        public void InsertLast(T item)
        {
            Node<T>? current = First;
            Node<T> newNode = new Node<T> { Data = item };
            if (First == null)
            {
                First = newNode;
                return;
            }
            while (current?.Next != null)
            {
                current = current.Next;
            }

            current!.Next = newNode;
        }

        public void ReverseLinkedList()
        {
            Node<T>? prev = null;
            Node<T>? curr = First;
            while (curr != null)
            {
                Node<T>? next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            First = prev;
        }
    }
}
