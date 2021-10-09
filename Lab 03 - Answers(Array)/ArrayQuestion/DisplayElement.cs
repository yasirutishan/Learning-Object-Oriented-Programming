using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayQuestion
{
    class DisplayElement
    {
        
        public void display() 
        {
            DefineArray da1 = new DefineArray();

            Console.WriteLine("The value in the zeroth index : " + da1.getData());
        }
    }
}
