using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");

            decimal number6 = 10.4m;
            double number5 = 10.4; //can hold decimals
            char character = 'A'; //can hold characters
            bool condition = false;// True or false
            byte number4 = 255; // 8bytes of data
            short number3 = 32767; //16bytes of data
            int number1 = 2147483647; //32 bytes
            long number2 = 2147483648; // (64bytes)can hold twice the amount than int
            //var number7 = 10;
            //number7 = 'A';

            Console.WriteLine("Number1 is {0}" ,number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Character is: {0}", character);
            Console.WriteLine((int)Days.friday);
            Console.WriteLine("number7 is {0}" ,number7);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, tuesday, wednesday, thursday, friday, saturday, sunday
    }
}
