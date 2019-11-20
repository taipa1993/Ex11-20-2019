using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11202019
{
    class InputHelper
    {
        public static int InputInteger()
        {
            int number;
        checkNumber:
            bool isInt = int.TryParse(Console.ReadLine(), out number);
            if (isInt)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Please enter an interger number :");
                goto checkNumber;
            }

        }
        public static double InputDouble()
        {
            double number;
        checkNumber:
            bool isInt = double.TryParse(Console.ReadLine(), out number);
            if (isInt)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Please enter an double number :");
                goto checkNumber;
            }
        }
        

    }
}
