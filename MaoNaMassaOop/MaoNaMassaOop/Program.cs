using System;
using MaoNaMassaOop.ContentContext;

namespace MaoNaMassaOop 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var carrer = new Careers();
            carrer.Items.Add(new CareerItem());
            Console.WriteLine(carrer.TotalCourses);
            

        }
    }
}
