// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
LinkedList.CustomLinkedList<int> list = new LinkedList.CustomLinkedList<int>();
list.InsertLast(100);
list.InsertFirst(200);
list.InsertLast(290);
list.InsertFirst(50);
list.DisplayList();
Console.WriteLine();
list.ReverseLinkedList();
list.DisplayList();
Console.WriteLine();
list.DeleteFirst();
list.DeleteFirst();
list.DisplayList();
Console.WriteLine();
list.ReverseLinkedList();
list.DisplayList();
Console.WriteLine();

Stack<int> stack = new Stack<int>();