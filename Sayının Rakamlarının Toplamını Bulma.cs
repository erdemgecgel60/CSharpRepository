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
            int toplam = 0;

            Console.WriteLine("Sayi : ");
            
            sayi = Convert.ToInt32(Console.ReadLine());

            do 
            {

                toplam += sayi % 10;

                sayi = sayi / 10;

            }
            while(sayi > 0);

            Console.WriteLine("Toplam : " + toplam);


        }
    }
}
