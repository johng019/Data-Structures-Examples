using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures3
{
    class InsertionSort
    {
        //Insertion sort
        static void Main(string[] args)
        {
            //Create an integer array
            int[] a = { 12, 4, 18, 7, 2, 19, 6, 20 };

            //temp variable to hold a value of index being 
            //starting with j-1 in my example, then j.
            int temp = 0;

            //increment thru the array
            for (int i = 1; i < a.Length -1; i++)
            {
                int j = i;
           
                //comparing values of 2 indexes, swap if neccessary
                while (j > 0 && a[j] < a[j-1])
                {
                    temp = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = temp;
                    j = j - 1;
                }
            }
            //print out the sorted array
            for (int k = 0; k < a.Length; k++) Console.WriteLine(a[k] + " ");
            Console.ReadLine();
        }
    }
}
