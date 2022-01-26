using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic program");
            BasicProgram prob = new BasicProgram();
            prob.Factorization(36);
            Console.ReadLine();
        }
    }
}
