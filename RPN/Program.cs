using System;
using System.IO;
using System.Collections.Generic;

namespace RPN
{   
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator("|3+2*(5+7)|");
            Console.WriteLine(calc.Answer);


        }
    }
}