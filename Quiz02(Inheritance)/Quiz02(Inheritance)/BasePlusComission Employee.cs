using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz02_Inheritance_
{
    class BasePlusComission_Employee : Commision_Employee
    {
        double basicSalary;
        

        public BasePlusComission_Employee(double basicSal, double comRate , double grossSal) : base(comRate,grossSal)
        {
            this.basicSalary = basicSal;
        }

        public double earning()
        {
            double netSal = basicSalary + (commissionRate * grossSales);
            return netSal;
        }
    }
}
