using Search;
using Search.BinarySearchTree;

Console.WriteLine("Hello, World!");

/**--- Binary Search Tree ---**/

SearchTree<string> tree = new SearchTree<string>();
tree.Insert(6, "Kishore");
tree.Insert(23, "adgs");
tree.Insert(152, "ikjh");
tree.Insert(4, "qwe");
tree.Insert(1, "rty");
tree.PrintBinaryTree();

/**--- Searching ---**/

int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
int[] ar = new int[2146435071];
for (int i = 0; i < ar.Length; i++)
{
    ar[i] = i;
}

BinarySearch search1 = new BinarySearch();
var bsResult = search1.ElementFoundAt(ints, 7);
Console.WriteLine(bsResult < 0 ? "Not found" : $"Element found at {bsResult + 1}");
bsResult = search1.ElementFoundAt(ints, 2);
Console.WriteLine(bsResult < 0 ? "Not found" : $"Element found at {bsResult + 1}");
bsResult = search1.ElementFoundAt(ints, 11);
Console.WriteLine(bsResult < 0 ? "Not found" : $"Element found at {bsResult + 1}");
bsResult = search1.ElementFoundAt(ints, 0);
Console.WriteLine(bsResult < 0 ? "Not found" : $"Element found at {bsResult + 1}");

LinearSearch<int> search = new LinearSearch<int>();
bool result;
int count = 0;
var watch = System.Diagnostics.Stopwatch.StartNew();
result = search.IsFound(ints, 11, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.IsFound(ints, 5, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.FasterIsFound(ints, 11, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.FasterIsFound(ints, 5, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.DoubleFasterIsFound(ints, 11, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.DoubleFasterIsFound(ints, 5, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.IsFound(array, 16, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.IsFound(array, 8, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.FasterIsFound(array, 16, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.FasterIsFound(array, 8, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.DoubleFasterIsFound(array, 16, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.DoubleFasterIsFound(array, 8, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.IsFound(ar, int.MaxValue/2, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.FasterIsFound(ar, int.MaxValue/2, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.DoubleFasterIsFound(ar, int.MaxValue / 2, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.IsFound(ar, (int.MaxValue / 2) - 1, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.FasterIsFound(ar, (int.MaxValue / 2) - 1, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.DoubleFasterIsFound(ar, (int.MaxValue / 2) - 1, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.IsFound(ar, (int.MaxValue / 2) + 1, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.FasterIsFound(ar, (int.MaxValue / 2) + 1, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");

count = 0;
watch.Restart();
result = search.DoubleFasterIsFound(ar, (int.MaxValue / 2) + 1, out count);
watch.Stop();
Console.WriteLine($"Status: {result}! Iteration: {count} Time taken: {watch.ElapsedTicks}");