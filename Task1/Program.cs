using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Введите значение a:");

            string lineA = Console.ReadLine();
            a = Convert.ToInt32(lineA);

            Console.WriteLine("Введите значение b:");

            string lineB = Console.ReadLine();
            b = Convert.ToInt32(lineB);

            Console.WriteLine("Поменять значения местами?");
            int c = a;
           a = b;
           b = c;
           Console.ReadKey();
            
            Console.WriteLine($"Значение A = {a}, а значение В = {b}!");
            Console.ReadKey();
        }
    }
}
