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


            int satir;
            int sutun; 
           
            Console.WriteLine("Satir : ");
            
            satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sutun : ");

            sutun = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < satir; i++) 
            {

                for(int j = 0; j < sutun; j++) 
                {

                    Console.Write("*");

                }
                Console.WriteLine();


            }
 

        }
    }
}
