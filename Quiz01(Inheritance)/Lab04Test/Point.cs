using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Lab04Test
{
    class Point
    {
       
        int x , y ;


        public Point(int num1 , int num2 ) 
        {
            this.x = num1;
            this.y = num2;
        }

        public void display()
        {
            Console.WriteLine("Circle [Centre (" + x + "," + y + ");" );
        }



    }
}
