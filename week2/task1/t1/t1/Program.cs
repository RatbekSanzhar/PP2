using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\pp2\week2\task1\input.txt", FileMode.Open, FileAccess.Read); // open file stream, open my file and read  
            StreamReader sr = new StreamReader(fs); // open the stream reader
            string s = ""; 
            s = sr.ReadLine(); // assign the text from file to string s 
            
            bool check = true;
            for (int i = 0; i < s.Length; i++) // run the loop
            {
                if (s[i] != s[s.Length - i - 1]) // checking is it polindrom
                {
                    check = false; // if  it isn`t polindrom false
                    break;
                }
            }
            if (check) Console.Write("YES"); // if it`s polindrom yes 
            else Console.Write("NO"); // if it`s polindrom no

            fs.Close(); // close file stream
            sr.Close(); // close stream reader 
            Console.ReadKey();
        }
    }
}



