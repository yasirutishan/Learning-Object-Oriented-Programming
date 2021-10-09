using System;

namespace Encap
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad;

            Console.WriteLine("Enter the value of the radius of the circle: ");
            rad = Double.Parse(Console.ReadLine());

            EncapData ed1 = new EncapData();

            //ed1.setRadius(rad);

            //Console.WriteLine("The radius of the circle is : " + ed1.getRadius());

            Console.WriteLine("The area of the circle is : " + ed1.calculateArea(rad));

            Console.WriteLine("The circumference of the circle is : " + ed1.calculateCircumference());

            Console.ReadKey();
        }
    }
}
