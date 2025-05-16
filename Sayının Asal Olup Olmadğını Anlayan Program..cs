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

            bool asal = true;
             

            Console.WriteLine("Sayi : ");
            
            sayi = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 2; i < sayi; i++) 
            {

                if (sayi % i == 0)
                {
                    asal = false;
                    break;
                }

            }

            if (asal)
            {
                Console.WriteLine("Asal sayi");
            }
            else
            {
                Console.WriteLine("Asal sayi degil");
            }


        }
    }
}
