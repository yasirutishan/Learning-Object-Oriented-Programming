using System;
using System.Collections.Generic;
using System.Text;

namespace Encap
{
    class EncapData
    {
        private double radius;
        private double pi = 3.14;

       /* public void setRadius(double r)
        {
            this.radius = r;
        }

        public double getRadius()
        {
            return radius;
        }*/

        public double calculateArea(double r)
        {
            this.radius = r;
            double area = pi * radius * radius;
            return area;
        }

        public double calculateCircumference()
        {
            double circum = 2 * pi * radius ;
            return circum;
        }
    }
}
