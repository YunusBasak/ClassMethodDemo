using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Yunus ";
            musteri1.MusteriSoyadi = "Başak";



            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Ahmet ";
            musteri2.MusteriSoyadi = "Başak";



            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Ali ";
            musteri3.MusteriSoyadi = "Başak";





            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var item in musteriler)
            {
                Console.WriteLine(item.MusteriId);
                Console.WriteLine(item.MusteriAdi);
                Console.WriteLine(item.MusteriSoyadi);

            }

            Console.WriteLine(" ");

            //Musteri Ekleme

            MusteriManager musteri = new MusteriManager();

            musteri.Ekle(musteri1);
            musteri.Ekle(musteri2);
            musteri.Ekle(musteri3);

            Console.WriteLine(" ");

            //Musteri Silme

            MusteriManager musterix = new MusteriManager();
            musterix.Sil(musteri1);
            musterix.Sil(musteri2);
            musterix.Sil(musteri3);

            Console.WriteLine(" ");

            // Musteri Listeleme

            MusteriManager musteriy = new MusteriManager();
            musteriy.Liste(musteri1);
            musteriy.Liste(musteri2);
            musteriy.Liste(musteri3);

            Console.ReadLine();


        }
    }


}
