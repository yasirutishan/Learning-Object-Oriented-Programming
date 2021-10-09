using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace Lab04Test
{
    class Circle : Point
    {
        protected double r;
        double pi = 3.14;



        public Circle(int x, int y,double rad) : base(x,y) 
        {
            r = rad;
            //insert the equation to draw the circle using the coordinates
        }

        public void display()
        {
            base.display();
            Console.WriteLine("Radius = " + r + "]");
        }


        public double getArea()
        {
            return (pi * r * r);
        }

        public double getCircumference()
        {
            return (2 * pi * r);
        }

  

    }
}
