using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            Car BMW = Car.Create(2.0, "Bmka");
            Console.WriteLine(BMW.marka);
            Console.WriteLine(BMW.pojSilnika);
           
            
            Console.ReadKey();
        }
    }
}
