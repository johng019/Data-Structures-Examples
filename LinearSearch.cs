using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures2
{
    class LinearSearch
    {
        //Linear search..unsorted array.
        static void Main(string[] args)
        {
            //create an integer array
            int[] a = { 9, 4, 7, 1, 8, 3, 5,2};

            //temp variable of target value
            int target = 8;

            //search thru the array 
            for (int i = 0; i < a.Length; i++)
            {
                //if the target value is found
                if (a[i] == target)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
