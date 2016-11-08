using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures5
{
    class BinarySearch
    {
        //Binary search...(Sorted)
        //Find the value of the integer at the specified index of the array
        static void Main(string[] args)
        {
            //create an integer array
            int[] a = { 1, 3, 5, 7, 9, 11, 13, 15 };

            //temp variable for index # to be compared
            int low = 0;

            //temp variable for length of the array
            int high = a.Length;

            //temp variable for the integer we want returned
            //int target = a[6]; *see comment at bottom
            int target = 3;

            //increment thru the array until the end of the array OR specified value is found
            while (low + 1 < high)
            {
                int test = (low + high) / 2;
                if (a[test] > target)
                {
                    high = test;
                }
                else
                {
                    low = test;
                }
            }
            if (a[low] == target)
            {
                //returns the value or....
                Console.WriteLine(a[low]);
            }
            else
            {
                //returns if value specified does not exist in the array
                Console.WriteLine("Value not found");
            }
            Console.ReadLine();
        }
    }
    /*
      Line 22 can be changed if you want to search for the value 
      at a specific index position:
      int target = a[6];
      This would return 13, which is the integer value at index 6 of the array.
    */
}
