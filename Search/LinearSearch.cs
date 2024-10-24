using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class LinearSearch<T>
    {
        // Complexity -> O(n)
        public bool IsFound(T[] items, T key, out int count)
        {
            count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]!.Equals(key))
                {
                    return true;
                }
                count++;
            }
            return false;
        }

        // Complexity -> O(n/2)
        /*
         * 
         * Though the iterations are reduced, the time taken for execution is more 
         * 
         */
        public bool FasterIsFound(T[] items, T key, out int count)
        {
            count= 0;
            int len = items.Length;
            int mid = (len / 2) + 1;
            for (int i = 0; i < mid; i++)
            {
                if (items[i]!.Equals(key) || items[len - 1 - i]!.Equals(key))
                {
                    return true;
                }
                count++;
            }
            return false;
        }

        public bool DoubleFasterIsFound(T[] items, T key, out int count)
        {
            count = 0;
            int len = items.Length;
            int mid = (len / 2) + 1;
            for (int i = 0; i < ((mid / 2) + 1); i++)
            {
                if (items[i]!.Equals(key) || items[mid - i]!.Equals(key) || items[mid + i]!.Equals(key) || items[len - 1 - i]!.Equals(key))
                {
                    return true;
                }
                count++;
            }
            return false;
        }
    }
}
