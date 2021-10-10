using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        int[] arr = new int[10];
        

        public void setValues() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Enter number" + (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void maxValue() {
            int max= arr[0];
            for (int i = 0; i < 10; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }

        public void minValue() {
            int min = arr[0];
            for (int i = 0; i < 10; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }   
            }
            Console.WriteLine(min);
        }

        public void findAverage() {
            int total=0;
            double avg;

            for (int i = 0; i < 10; i++) {
                total = total + arr[i];
            }
            avg = (double)total / 10;

            Console.WriteLine(avg);
        }

        public void reverseOrder() {
            for (int i = 9; i >= 0; i--) {
                Console.Write(arr[i]+" , ");
            }
        }





    }
}
