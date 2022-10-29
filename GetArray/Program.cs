using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArray
{
   
    public static class Extensions
    {
        public static T[] CopyTo<T>(this T[] source, int start, int end)
        {
            int count = 1;
            int index = 0;
            T[] copied = new T[count];

            for (int i = start; i <= end; i++)
                copied[index++] = source[i];
            return copied;
        }
    }
    class Program
    {
        static void Main()
        {
            var orig = new int[] { 6, 7, 9, 21, 3 };
            var newArray = orig.CopyTo(5, 1);
        }
    }
}
