using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine()); // enters a line by converting string to integer
            String s = Console.ReadLine();  // read String from console
            string[] parts = s.Split();  //parse String to array of chars


            int count = 0;
            for (int i = 0; i < s.Length; i++)  //checking is the digit is prime, if yes count them
            {
                if (isPrime(s[i] - '0')) count++;
            }
            Console.WriteLine(count);  // write count to the console
            for (int i = 0; i < s.Length; i++)
            {
                if (isPrime(s[i] - '0')) Console.Write(s[i] + " ");
            }

            Console.ReadKey();
        }
        static bool isPrime(int a)  // func to check
        {
            if (a < 2) return false;

            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}
