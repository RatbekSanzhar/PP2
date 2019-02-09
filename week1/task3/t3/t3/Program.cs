using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());  // read a number from console
            string[] s = Console.ReadLine().Split(); // create an array from string
            for (int i=0; i<a; i++) // run the loop
            {
                Console.Write(s[i] + " " + s[i] + " "); // write to console
            }
            Console.ReadKey();
        }
    }
}
