using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Student // creates a new class
    {
        public string name; // a new field
        public int id; // a new field
        public int year=1; // a new field

        public Student(string name, int id) //creates a constructor
        {
            this.name = name; // assign a value
            this.id = id; // assign a value
        }
        public string getName()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }
        
        public void IncYear() // creates a method of increment of year
        {
            year++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

