using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class BasicProgram
    {
        public void Quotientremainder(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:" + dividend + " Divisor: " + divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
        
    
}
