using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 92;
            //if (number==10)//eger sayı 10 ise
            //{
            //    Console.WriteLine("Numbers is 10");
            //}
            //else if (number ==20) //eğer 20 ise de bunu çalıştır
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else// 10 değilse
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}
            //Console.ReadLine();
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break; //olayı kes
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;

            //if (number >= 0 && number <= 100) //iki şart birden saglanırsa
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number>100 && number <=200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number>200 || number < 0)  // || veya demek
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}


            if (number<100)
            {
                if (number>=90&&number<95)
                {
                    Console.WriteLine("dogru");
                }
            }
        }
        Console.ReadLine();
        }
}
}
