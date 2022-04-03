using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class InputHelper
    {

        public static int GetInputInt(string title)
        {
            Console.WriteLine(title);
            int value =  Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return value;

        }

        public static double GetInputDouble(string title)
        {
            Console.WriteLine(title);
            double value = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            return value;

        }

        public static string GetInputString(string title)
        {
            Console.WriteLine(title);
            string value = Console.ReadLine();
            Console.Clear();

            return value;

        }


    }
}
