using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace sorting_and_interface
{
    public static  class sotr
    {
        class sort : Isorting
        {
            public void SortanArray()
            {
                int[] intArray = new int[] { 3, 5, 7, 9, 4, 15, 10, 4, 6, 8, 1, 11, 12, 14, 2, 13 };
                Console.WriteLine("original Array");
                foreach (int i in intArray)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("incresing order");
                Array.Sort(intArray);
                foreach (int i in intArray)
                { Console.Write(i + " "); }
                Console.WriteLine();
                Console.WriteLine("decreasing order");
                Array.Reverse(intArray);
                foreach (int i in intArray)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}