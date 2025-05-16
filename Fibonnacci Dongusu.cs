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


            int ilksayi = 1;
            int ikincisayi = 1;
            int piyonDegisken;
            int sayi;
             
           
            Console.WriteLine("Sayi : ");
            
            sayi = Convert.ToInt32(Console.ReadLine());
             
            for(int i = 0; i < sayi - 2; i++) 
            {

                piyonDegisken = ikincisayi;

                ikincisayi += ilksayi;

                ilksayi = piyonDegisken;


            }

            Console.WriteLine("Fibonacci Dongusu : " + ikincisayi);






        }
    }
}
