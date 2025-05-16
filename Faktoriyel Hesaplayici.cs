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
            int toplam = 1;
           
            Console.WriteLine("Sayi : ");
            
            sayi = Convert.ToInt32(Console.ReadLine());
             
            while(sayi > 0) 
            {

                toplam = toplam * sayi;

                sayi--;

            }

            Console.WriteLine("Toplam : " + toplam);






        }
    }
}
