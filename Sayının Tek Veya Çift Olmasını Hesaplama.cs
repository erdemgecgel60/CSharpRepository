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

            Console.WriteLine("Sayi : ");
            
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0) {

                Console.WriteLine("Sayi Cifttir");

            }

            else
            {
                Console.WriteLine("Sayi Tektir");
            }



        }
    }
}
