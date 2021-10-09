using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz02_Inheritance_
{
    class Commision_Employee : Employee
    {
        protected double commissionRate, grossSales;
        public Commision_Employee(double cr, double gs)
        {
            this.commissionRate = cr;
            this.grossSales = gs;
        }

        public double earning()
        {
            double netSal = commissionRate* grossSales;
            return netSal;
        }
    }
}
