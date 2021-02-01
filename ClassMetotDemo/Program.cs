using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Celik";
            musteri1.MusteriId = 123456;
            musteri1.MusteriAdres = "abc";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Emrah";
            musteri2.MusteriSoyadi = "Celik";
            musteri2.MusteriId = 789012;
            musteri2.MusteriAdres = "def";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Adı:" +" "+ musteri.MusteriAdi);
                Console.WriteLine("Musteri SoyAdı:" + " " + musteri.MusteriSoyadi);
                Console.WriteLine("Musteri Id:" + " " + musteri.MusteriId);
                Console.WriteLine("Musteri Adresi:" + " " + musteri.MusteriAdres);
                Console.WriteLine("*************yeni müsteri*************");

            }

            Console.WriteLine("-----------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
        }
    }
}
