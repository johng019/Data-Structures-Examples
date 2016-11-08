using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures1
{
    class BubbleSort
    {
        //Bubble sort
        static void Main(string[] args)
        {
            //create an integer array
            int[] arr = { 16, 32, 8, 4, 64, 128, 2, 1 };

            //temp variable to hold value of index being swapped 
            //In my case initially j+1 *see below
            int temp = 0;

            //increment thru the array
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    //while incrementing tru indexes compare and swap if neccessary
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
        }
            //prints out the sorted array
            for (int k = 0; k < arr.Length; k++) Console.WriteLine(arr[k] + " ");
            Console.ReadLine();
        }  
    }
}
