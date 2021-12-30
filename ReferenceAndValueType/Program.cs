using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            
            Console.WriteLine(number2);

            string[] cties1 = new string[] { "Ankara", "Adana", "Afyon" };//101
            string[] cties2 = new string[] { "Bursa", "Bolu", "Balıkesir" };//102
            cties2 = cties1; //101=102
            cties1[0] = "İstanbul";

            Console.WriteLine(cties2[0]);
            Console.ReadLine();
            
        }
    }
}
