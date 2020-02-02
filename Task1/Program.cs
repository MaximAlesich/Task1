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

            a = Helper.GetNumberFromConsole("Введите значение a: ");
            b = Helper.GetNumberFromConsole("Введите значение b: ");
            
            Console.WriteLine("Поменять значения местами?");
            Helper.ReplaceValues(ref a, ref b);
            Console.ReadKey();

            Console.WriteLine($"Значение A = {a}, а значение В = {b}!");
            Console.ReadKey();
        }             
    }
}