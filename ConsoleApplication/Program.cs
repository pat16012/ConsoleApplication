using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wrote by Justin Paton

            // Variables
            string name = "Justin Paton";
            string location = "Canada";
            
            //Variables and Date Calculations 
            var today = DateTime.Now;
            var daysToChristmas = new DateTime(DateTime.Now.Year, 12, 25);
            var dayChristmas = daysToChristmas - today.AddDays(-1);

            //Display to the console
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);
            Console.WriteLine("Current Date: " + today.ToString("dd/MM/yyy"));
            Console.WriteLine("Days until Christmas: " + dayChristmas.ToString("dd"));

        }
    }
}
