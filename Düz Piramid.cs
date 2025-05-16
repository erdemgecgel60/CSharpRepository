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



            int boyut;
            
           
            Console.WriteLine("Sayi : ");
            
            boyut = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < boyut; i++)
            {

                for(int j = 0; j <= i; j++) 
                {

                    Console.Write("*");

                }
                Console.WriteLine();

            }

          






        }
    }
}
