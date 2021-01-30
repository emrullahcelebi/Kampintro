using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            
            double number5 = 10.4; //64 byte 
            decimal number6 = 10.41111m;
            char character = 'A';
            bool condition = false;
            byte number4 = 255; //0 ile 255 arası
            short number3 = -32768;//16 bite yer kaplıyor
            int number1 = 2147483647;//32 bite yer kaplıyor
            long number2 = -9223372036854775808; // 64 bite yer kaplar
            var number7 = 10;
            number7 = 'A';
            
            
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
