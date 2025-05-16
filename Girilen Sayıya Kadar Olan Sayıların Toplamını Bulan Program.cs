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
             
            for(int i = 0; i < sayi; i++) 
            {

              
                toplam += i;

            }

            Console.WriteLine("Toplam : " + toplam);





        }
    }
}
