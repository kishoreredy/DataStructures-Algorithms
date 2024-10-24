using AlgorithmsDataStructures.ArrayCoding;
using AlgorithmsDataStructures.LeetCode;
using AlgorithmsDataStructures.Sorting;

Console.WriteLine("Ice Cream");
Console.WriteLine(ReverseVowels.Do("Ice Cream"));

int[] ints = [1, 4, 6, 3, 2, 7, 2, 3, 1];
Console.WriteLine(string.Join(' ', ints));
Console.WriteLine(string.Join(' ', FindNextGreaterElementForEachItem.Do(ints)));

int[] kth = [1, 4, 6, 3, 2, 7, 8, 45, 67, 46, 86, 238, 86, 2, 3, 1];
Console.WriteLine(string.Join(' ', kth));
Console.WriteLine(KthLargestElement.GeneralApproach(kth, 3)); // not effective for duplicates

kth = [1, 4, 6, 3, 2, 7, 8, 45, 67, 46, 86, 238, 86, 2, 3, 1];
Console.WriteLine(KthLargestElement.QuickSelect(kth, 3));  // not effective for duplicates

kth = [1, 4, 6, 3, 2, 7, 8, 45, 67, 46, 86, 238, 2, 3, 1];
Console.WriteLine(KthLargestElement.QuickSelect(kth, 3));  // not effective for duplicates

kth = [1, 4, 6, 3, 2, 7, 8, 45, 67, 46, 86, 238, 2, 3, 1];
Console.WriteLine(KthLargestElement.MinHeap(kth, 3));

kth = [1, 4, 6, 3, 2, 7, 8, 45, 67, 46, 86, 23, 83, 84, 85, 86, 2, 3, 1];
Console.WriteLine(KthLargestElement.MinHeap(kth, 3));

kth = [1, 4, 6, 3, 2, 7, 8, 45, 67, 46, 86, 23, 83, 84, 85, 86, 2, 3, 1];
Console.WriteLine(KthLargestElement.MinHeap(kth, 4));

kth = [1, 4, 6, 3, 2, 7, 5, 2, 3, 1];
Console.WriteLine(KthLargestElement.MinHeap(kth, 4));

kth = [23, 22, 23, 21, 22, 24, 25, 25, 26, 26];
Console.WriteLine(KthLargestElement.MinHeap(kth, 4));

kth = [3, 2, 3, 1, 2, 4, 5, 5, 6];
Console.WriteLine(KthLargestElement.MinHeap(kth, 4));

kth = [2,1];
Console.WriteLine(KthLargestElement.MinHeap(kth, 3));

kth = [345, 4, 6, 3, 2, 7, 8, 45, 67, 46, 86, 23, 84, 85, 86, 2, 3, 123];
Console.WriteLine(KthSmallestElement.MaxHeap(kth, 3));

MergeSort.Sort([9, 8, 7, 6, 6, 5, 1, 4, 2, 3]);


SortedSet<int> s = new SortedSet<int>();
s.Add(1);
s.Add(2);
s.Add(10);
s.Add(5);
s.Add(2);

Console.WriteLine(string.Join(' ', s));

// LeetCode
_1514_PathWithMaxProbability.Test();