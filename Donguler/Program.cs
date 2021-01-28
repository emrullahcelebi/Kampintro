using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


           
            //array-dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı" ,
                "Programlamaya başlangıç için temel kurs" ,"Java","Python","C++"};


            for (int i = 0; i <kurslar.Length; i++)          //i++ demek bir bir arttır demek
            {                                 //i=i+2 i yi 2 2 arttır demek bunun şğylede yazılır i+=2
                                                // dizileri dolaşıyoruz

                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)   //dizileri dolaşmak için bu da kullanılır
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
