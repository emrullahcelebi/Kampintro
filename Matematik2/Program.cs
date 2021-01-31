using System;

namespace Matematik2
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem2 dortIslem1 = new DortIslem2();
            dortIslem1.Topla(5, 6);

            dortIslem1.Topla(6, 9);

            Console.WriteLine("-------------11111-------------");

            DortIslem2 dortIslem2 = new DortIslem2();
            dortIslem2.Cikar(18, 6);

            dortIslem2.Cikar(27, 9);

            Console.WriteLine("-------------222222-------------");

            DortIslem2 dortIslem3 = new DortIslem2();
            dortIslem3.Carp(5, 6);

            dortIslem3.Carp(6, 9);

            Console.WriteLine("------------3333333-------------");

            DortIslem2 dortIslem4 = new DortIslem2();
            dortIslem4.Bol(12, 6);

            dortIslem4.Bol(27, 9);


            Console.WriteLine("*****MÜKEMMEL ÇALIŞMA*****");
        }
    }
}
