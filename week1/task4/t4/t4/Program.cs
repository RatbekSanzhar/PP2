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

             int n = int.Parse(Console.ReadLine());  // read a number from console
             int[] a = new int[n];  // create an array
             string[] s = Console.ReadLine().Split(); // create an array from string
             for (int i = 0; i < n; i++)  // run the loop
             {
                a[i] = int.Parse(s[i]); // convert from string to int
             }
             a = DoubleArr(a);  //  assign the result of method DoubleArr to array a
             for (int i=0; i<a.Length;i ++) // run the loop
             {
             Console.Write(a[i] + " "); // write to console
             }
             Console.ReadKey();
        }
            
        static int[] DoubleArr(int[] a) // method DoubleArr that writes every element of array twice
        {
             int[] newArr = new int[a.Length * 2];  // i create the new array with doubled up length
             for (int i=0; i<a.Length; i++) // run the loop
             {
              newArr[i * 2] = a[i]; // write the elements twice
              newArr[i * 2 + 1] = a[i]; 
             }
            return newArr; // return my double up array
        }
    }
}

