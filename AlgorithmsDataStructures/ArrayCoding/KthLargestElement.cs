using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.ArrayCoding
{
    internal class KthLargestElement
    {
        public static int MinHeap(int[] ints, int k)
        {
            int removed = 0;
            SortedSet<int> sorted = new SortedSet<int>();
            foreach (int i in ints)
            {
                sorted.Add(i);
                if (sorted.Count > k)
                {
                    removed++;
                    sorted.Remove(sorted.Min);
                }
            }

            if (removed >= k - 1)
            {
                return sorted.Min;
            }
            return sorted.ElementAtOrDefault(k - removed - 1);
        }

        public static int GeneralApproach(int[] ints, int k) // not efficient for duplicates
        {
            Array.Sort(ints);
            Console.WriteLine(ints[ints.Length - k]);
            Array.Reverse(ints);
            return ints[k - 1];
        }

        public static int QuickSelect(int[] ints, int k)  // not effective for duplicates
        {
            List<int> list = new List<int>(ints);
            return QuickSelect(list, k);
        }

        private static int QuickSelect(List<int> list, int k)
        {
            // randomly selecting a pivot
            Random rnd = new Random();
            int pivot = list[rnd.Next(list.Count)];

            // for elements greater than pivot
            List<int> right = new List<int>();

            // for elements equal to pivot
            List<int> mid = new List<int>();

            // for elements less than pivot
            List<int> left= new List<int>();

            // partitioning based on pivot
            foreach (int i in list)
            {
                if (i > pivot)
                {
                    right.Add(i);
                }
                else if (i < pivot)
                {
                    left.Add(i);
                }
                else
                {
                    mid.Add(i);
                }
            }

            // Recursive selection
            if (right.Count >= k)
            {
                return QuickSelect(right, k);
            }
            if(right.Count + mid.Count < k)
            {
                return QuickSelect(left, k-right.Count-mid.Count);
            }

            return pivot;
        }
    }
}
