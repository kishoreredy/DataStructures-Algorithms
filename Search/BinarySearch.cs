using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class BinarySearch
    {
        public int ElementFoundAt(int[] values, int value)
        {
            int start = 0;
            int end = values.Length;
            int result = -1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (values[mid].Equals(value))
                {
                    return result = mid;
                }
                else if (values[mid] > value)
                {
                    end = mid;
                }
                else if (values[mid] < value)
                {
                    start = mid + 1;
                }
            }
            return result;
        }
    }
}
