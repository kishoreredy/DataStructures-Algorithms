using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.ArrayCoding
{
    internal class ReverseVowels
    {
        public static string Do(string s)
        {
            int count = 0;
            Queue<int> positions = new Queue<int>();
            Stack<char> vowels = new Stack<char>();
            foreach (char c in s)
            {
                count++;
                switch (c)
                {
                    case 'a':
                    case 'A':
                    case 'i':
                    case 'I':
                    case 'e':
                    case 'E':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        positions.Enqueue(count - 1);
                        vowels.Push(c);
                        break;
                    default:
                        continue;
                }
            }
            var res = s.ToCharArray();
            var len = positions.Count;
            for (int i = 0; i < len; i++)
            {
                int pos = positions.Dequeue();
                char ch = vowels.Pop();
                res[pos] = ch;
            }
            return new string(res);
        }
    }
}
