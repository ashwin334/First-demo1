using FirstDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of Date class
            Date d1 = new Date(); // new allocate memory
            d1.Add(8, "Oct", 2022);
         Console.WriteLine(d1.Print());


          Date d2 = new Date();
          d2.Add(9, "Oct", 2022);
          Console.WriteLine(d2.Print());

        }
    }
}
