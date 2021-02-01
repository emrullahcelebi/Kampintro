using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Tebrikler. Yeni Müşteri Ekledi:" +" "+ musteri.MusteriAdi +" "+ musteri.MusteriSoyadi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Musteri Adı:" + " " + musteri.MusteriAdi);
            Console.WriteLine("Musteri SoyAdı:" + " " + musteri.MusteriSoyadi);
            Console.WriteLine("Musteri Id:" + " " + musteri.MusteriId);
            Console.WriteLine("Musteri Adresi:" + " " + musteri.MusteriAdres);
            Console.WriteLine("--------------Tebrikler--------------");

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Silinen Musteri Adı:" + " " + musteri.MusteriAdi);
            Console.WriteLine("Silinen Musteri SoyAdı:" + " " + musteri.MusteriSoyadi);
            Console.WriteLine("--------------Tebrikler Müşteri Silindi--------------");
        }

    }
}
