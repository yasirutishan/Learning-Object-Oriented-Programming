using System;

namespace Lab04Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for X coordinate : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for Y coordinate : ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for radius : ");
            double radius = Double.Parse(Console.ReadLine());

            Circle c1 = new Circle(x,y,radius);
            c1.display();

            Console.WriteLine("Area of the Circle : " + c1.getArea());
            Console.WriteLine("Circumference of the Circle : " + c1.getCircumference());


            Console.ReadKey();
        }
    }
}
