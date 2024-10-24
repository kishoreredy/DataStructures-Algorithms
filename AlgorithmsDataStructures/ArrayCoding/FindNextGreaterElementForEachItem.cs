using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.ArrayCoding
{
    internal class FindNextGreaterElementForEachItem
    {
        public static int[] Do(int[] a)
        {
            int len = a.Length;
            int[] result = new int[len];
            Stack<int> positions = new Stack<int>();

            for (int i = len - 1; i >= 0; i--)
            {
                while (positions.Count > 0 && positions.Peek() <= a[i])
                {
                    positions.Pop();
                }
                result[i] = positions.Count == 0 ? -1 : positions.Peek();
                positions.Push(a[i]);
            }

            return result;
        }
    }
}
