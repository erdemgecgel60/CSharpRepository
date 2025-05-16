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


            int sayi;

            int hane = 0;
             

            Console.WriteLine("Sayi : ");
            
            sayi = Convert.ToInt32(Console.ReadLine());
            
            do
            {

                sayi = sayi / 10;

                hane++;

            }
            while (sayi > 0);

            Console.WriteLine("Hane Sayisi : " + hane);

        }
    }
}
