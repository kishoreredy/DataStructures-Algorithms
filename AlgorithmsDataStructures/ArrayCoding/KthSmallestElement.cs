using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.ArrayCoding
{
    internal class KthSmallestElement
    {
        public static int MaxHeap(int[] ints, int k)
        {
            SortedSet<int> sorted = new SortedSet<int>();
            foreach (int i in ints)
            {
                sorted.Add(i);
                if (sorted.Count > k)
                {
                    sorted.Remove(sorted.Max);
                }
            }
            return sorted.Max;
        }
    }
}
