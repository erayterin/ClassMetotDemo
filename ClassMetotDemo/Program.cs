using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Eray";
            musteri1.Soyad = "Terin";
            musteri1.Bakiye = 2.999;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Emre";
            musteri2.Soyad = "Terin";
            musteri2.Bakiye = 3.999;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
           // musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);
            //musteriManager.Sil(musteri1);

        }
    }
}
