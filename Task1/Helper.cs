using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   public static class Helper
    {
        public static int GetNumberFromConsole(string textToShowInConsole)
        {
            Console.WriteLine(textToShowInConsole);

            string line = Console.ReadLine();
            int number = Convert.ToInt32(line);
            return number;
        }

        public static void ReplaceValues(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
            ReplaceValues(ref first, ref second);
        }

    }
}
