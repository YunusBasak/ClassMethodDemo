using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! Kaydınız eklendi :" + musteri.MusteriAdi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Kaydınız Silindi! : " + musteri.MusteriAdi);
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Kaydınız Listelendi! : " + musteri.MusteriAdi);
        }


    }
}
