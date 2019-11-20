using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex11202019
{
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            BaseClass exercise;
            

            Console.Write("Input select: ");
            select = InputHelper.InputInteger();

            switch (select)
            {
                case 1:
                    exercise = new TestArr();
                    break;
                case 2:
                    exercise = new TestList();
                    break;
                default:
                    exercise = new TestArr();
                    break;
            }

            exercise.Run();

        }

        
    }
}
