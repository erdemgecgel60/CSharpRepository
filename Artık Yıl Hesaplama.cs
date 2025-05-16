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



            int yil;

            Console.WriteLine("Yil : ");

            yil = Convert.ToInt32(Console.ReadLine());

            if (yil % 4 == 0) 
            {

                if (yil % 100 == 0)
                {
                    if (yil % 400 == 0)
                    {
                        Console.WriteLine("Artik Yil");
                    }
                    else
                    {
                        Console.WriteLine("Artik Yil Degil");
                    }
                }
                else
                {
                    Console.WriteLine("Artik Yil");
                }


            }
             
            else
            {
                Console.WriteLine("Artik Yil Degil");
            }











        }
    }
}
