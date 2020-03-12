using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lion
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double lion = 23000;
            while(lion>6000)
            {
                lion = lion - (lion * 0.02);
                counter++;
            }
            Console.WriteLine($"Lions will be extinct in {counter} years");
        }
    }
}
