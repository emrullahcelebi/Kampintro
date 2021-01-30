using System;

namespace deneme11111
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine(Add4(1,2,3,4,5,6));
        }
        static int Add4(params int[] numbers) 
        {
            return numbers.Sum();
        }
    }
}
