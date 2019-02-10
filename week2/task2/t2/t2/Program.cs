using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {


            FileStream fs = new FileStream(@"C:\Users\user\Desktop\pp2\week2\task2\digits.txt", FileMode.Open, FileAccess.Read); // open file stream, to open file and read
            StreamReader sr = new StreamReader(fs); //open the stream reader
            String s = sr.ReadLine(); //assign the text from file to string s
            String[] parts = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            int[] a = new int[parts.Length];

            for (int i = 0; i < a.Length; i++) // run the loop
            {
                a[i] = int.Parse(parts[i]);
            }

            FileStream fs1 = new FileStream(@"C:\Users\user\Desktop\pp2\week2\task2\output.txt", FileMode.OpenOrCreate, FileAccess.Write); // open file, write result
            StreamWriter sw = new StreamWriter(fs1); // open the stream writer(fs1)
            String ans = ""; // create string
            for (int i = 0; i < a.Length; i++) // run the loop
            {
                if (isPrime(a[i])) ans += a[i] + " "; // add prime numbers
            }
            sw.Write(ans);
            sw.Close();
            fs1.Close();


            sr.Close();
            fs.Close();
        }


        static bool isPrime(int a) // to check function 
        {
            if (a == 1) return false;
            if (a == 2) return true;
            if (a == 3) return true;
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}
