using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            string TheLetterA;
            string TheLetterB;

            TheLetterA = Helpik.DataInput("Введите первое значение: ");
            TheLetterB = Helpik.DataInput("Введите второе значение: ");

            Console.WriteLine("Поменять значения местами?");
            Helpik.SwapData(TheLetterA, TheLetterB);
            Console.ReadKey();

            Console.WriteLine($"Вот Ваши буквы, стоящие наоборот: {TheLetterB}, {TheLetterA}");
            Console.ReadKey();
        }
    }
}
