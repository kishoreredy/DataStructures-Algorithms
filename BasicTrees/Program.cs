using BasicTrees;
using System.Reflection;

Console.WriteLine("Hello, World!");

// int Tree
Tree<int> intTree = new Tree<int>();
intTree.Root= new TreeNode<int>() { Data = 100 };
intTree.Root.Children = new List<TreeNode<int>>()
{
    new TreeNode<int> { Data = 50, Parent = intTree.Root },
    new TreeNode<int> { Data = 1, Parent = intTree.Root },
    new TreeNode<int> { Data = 150, Parent = intTree.Root }
};

intTree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new TreeNode<int> { Data = 30, Parent = intTree.Root.Children[2] },
    new TreeNode<int> { Data = 5, Parent = intTree.Root.Children[2] },
    new TreeNode<int> { Data = 11, Parent = intTree.Root.Children[2] }
};

intTree.Root.Children[2].Children[0].Children = new List<TreeNode<int>>()
{
    new TreeNode<int> { Data = 96, Parent = intTree.Root.Children[2].Children[0] },
    new TreeNode<int> { Data = 9, Parent = intTree.Root.Children[2].Children[0] }
};

// Office Hierarchy
Tree<Person> office = new Tree<Person>();
office.Root = new TreeNode<Person>()
{
    Data = new Person(100, "Marcin Jamro", "CEO"),
    Parent = null
};

office.Root.Children = new List<TreeNode<Person>>()
{
    new TreeNode<Person>()
    {
        Data = new Person(1, "John Smith", "Head of Development"),
        Parent=office.Root
    },
    new TreeNode<Person>()
    {
        Data = new Person(50, "Mary Fox", "Head of Research"),
        Parent=office.Root
    },
    new TreeNode<Person>()
    {
        Data= new Person(150, "Lily Smith", "Head of Sales"),
        Parent=office.Root
    }
};

//office.Root.Children[2].Children = new List<TreeNode<Person>>()
//{
//    new TreeNode<Person>()
//    {

//    }
//}