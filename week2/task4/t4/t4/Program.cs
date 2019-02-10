using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = "Myfile.txt";

            var cre = File.Create(@"C:\Users\user\Desktop\pp2\week2\task4\created\" + fileName); // create file
            cre.Close(); // close stream
            Console.ReadKey();
            // to see that file created
            File.Copy(@"C:\Users\user\Desktop\pp2\week2\task4\created\" + fileName, @"C:\Users\user\Desktop\pp2\week2\task4\copied\" + fileName); // copied file from 'created' to 'copied'
            File.Delete(@"C:\Users\user\Desktop\pp2\week2\task4\created\" + fileName); // deleted file from created


        }
    }
}


