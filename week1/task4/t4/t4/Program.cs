using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {

            String s = "[*]";  // creating [*]
            int n = int.Parse(Console.ReadLine()); //reading number from console
            //algorithm to create a stairs from [*]
            for (int i = 1; i <= n; i++) // run the loop
            {
                for (int j = 0; j < i; j++) // run the second loop
                {
                    Console.Write(s); // write to console "[*]"
                }
                Console.Write("\n"); // go to the next line
            }
            Console.ReadKey();
        }
    }
}

