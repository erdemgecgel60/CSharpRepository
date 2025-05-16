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

            if (sayi > 0) 
            {

                Console.WriteLine("Sayi Pozitif");

            }

            else if(sayi == 0) 
            {

                Console.WriteLine("Sayi Notr");
            }
            else
            {
                Console.WriteLine("Sayi Negatif");

            }

        }
    }
}
