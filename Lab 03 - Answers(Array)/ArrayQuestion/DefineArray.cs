using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayQuestion
{
    class DefineArray
    {
        public int getData() 
        {
            int size;

            Console.WriteLine("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for(int i = 0; i < arr.Length; i++)             //setting the values for the array
            {
                Console.WriteLine("Enter the number: " + (i+1));
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The values in the array :" );     //printing the values in the array
            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            return arr[0];          //return the value in the zeroth index

        }
    }
}
