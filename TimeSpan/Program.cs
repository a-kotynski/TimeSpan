using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2159184#content
namespace TimeAndSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            //here var stands for struct - TimeSpan() is a structure
            var timeSpan = new TimeSpan(1,2,3); //TimeSpan represents length of time

            //both lines do the same thing, the latter one is more readable
            var timeSpan1 = new TimeSpan(1,0,0); 
            var timeSpan2 = TimeSpan.FromHours(1); //static method on a timeSpan structure

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);//waiting on that line while debugging causes the duration valu increase
            var duration = end - start;
            Console.WriteLine(duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}