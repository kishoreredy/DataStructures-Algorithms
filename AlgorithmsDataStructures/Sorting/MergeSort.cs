using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Sorting
{
    internal class MergeSort
    {
        public static void Sort(int[] ar)
        {
            Console.WriteLine("Before Sort");
            Console.WriteLine(string.Join(' ', ar));
            DoSort(ar, 0, ar.Length-1);
            Console.WriteLine("After Sort");
            Console.WriteLine(string.Join(' ', ar));
        }

        private static void DoSort(int[] ar, int start, int end)
        {
            int mid;
            if (start < end)
            {
                mid = (start + end) / 2;
                DoSort(ar, start, mid);
                DoSort(ar, mid+1, end);
                Merge(ar, start, mid + 1, end);
            }
        }

        private static void Merge(int[] ar, int start, int mid, int end)
        {
            int[] temp = new int[ar.Length];
            int i, start_end, noOfElements, temp_pos;
            start_end = mid - 1;
            temp_pos = start;
            noOfElements = (end - start) + 1;
            while (start <= start_end && mid <= end)
            {
                if (ar[start] <= ar[mid])
                {
                    temp[temp_pos++] = ar[start++];
                }
                else
                {
                    temp[temp_pos++] = ar[mid++];
                }
            }

            while(start <= start_end)
            {
                temp[temp_pos++] = ar[start++];
            }

            while(mid <= end)
            {
                temp[temp_pos++] = ar[mid++];
            }

            for (i = 0; i < noOfElements; i++)
            {
                ar[end] = temp[end];
                end--;
            }
        }
    }
}
