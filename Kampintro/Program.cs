using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //tyre safety - tip güvenliği
            //Do not repeartyourself - kendini tekrarlama
            //değer tututcu- alias
            string kategoriEtikeit = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun) //1.şart büyle ise
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun) // eğer 2. şart geçerli ise
            {
                Console.WriteLine("Artış butonu");
            }
            else //eğer 1 ve 2. şartlar sağlanmıyorsa
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)

            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtikeit);

           

        }
    }
}
