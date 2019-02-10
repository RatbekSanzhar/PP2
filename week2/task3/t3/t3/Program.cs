﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\user\Desktop\pp2"); // indicate direct to folder
            printInfo(dir, 0); // send dir to printinfo method

            Console.ReadKey();
        }
        static void printInfo(FileSystemInfo dir, int k)
        {
            string line = new string('\t', k); // write the number of spaces before names of folders and files
            line += dir.Name; // write name after spaces
            Console.WriteLine(line); // write to console
            if (dir.GetType() == typeof(DirectoryInfo)) // check to file or folder
            {
                var f = (dir as DirectoryInfo).GetFileSystemInfos(); // say my folder as 'var f'
                foreach (var i in f) // run elements of this folder
                {
                    printInfo(i, k + 1); // run recursion
                }
            }
        }


    }
}


