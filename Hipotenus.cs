using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int kenar1;
            int kenar2; 
           
            Console.WriteLine("1.Kenar : ");
            
            kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Kenar : ");

            kenar2 = Convert.ToInt32(Console.ReadLine());

            double total = (kenar1 * kenar1) + (kenar2 * kenar2);

            double total2 = Math.Sqrt(total);

            Console.WriteLine("Hipotenüs : " + total2);




        }
    }
}
