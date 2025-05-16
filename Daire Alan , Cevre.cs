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



            double yaricap;
            double pi = 3.14;
            
           
            Console.WriteLine("Yaricap : ");
            
            yaricap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Daire Alani : " + pi * (yaricap * yaricap));
            Console.WriteLine("Daire Cevresi : " + pi * (yaricap * 2));











        }
    }
}
