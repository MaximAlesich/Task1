using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_continue
{
    public static class Helpik
    {
        public static string DataInput(string textToShowInConsole)
        {
            Console.WriteLine(textToShowInConsole);
            string TheLetter = Console.ReadLine();
            return TheLetter;
        }
      
        public static void SwapData(string first, string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }
    }
}



