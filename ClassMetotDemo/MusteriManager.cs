using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri Bakiye : " + musteri.Bakiye);
            Console.WriteLine("------------------------");
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("------------------------");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : " + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
                Console.WriteLine("Müşteri Bakiye : " + musteri.Bakiye);

                Console.WriteLine("------------------------");
            }
            

            Console.WriteLine("------------------------");
            Console.WriteLine("Müşteri Listelendi.");
            Console.WriteLine("------------------------");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(musteri.Ad + "\t" + musteri.Soyad + "\tAdlı müşteri silindi.");
            Console.WriteLine("------------------------");
        }
        public void ParaTransfer(Musteri musteri1,Musteri musteri2,double miktar)
        {
            if (musteri1.Bakiye >= miktar)
            {
                musteri2.Bakiye += miktar;
                musteri1.Bakiye = musteri1.Bakiye - miktar;
                Console.WriteLine("Hesap No : " + musteri2.HesapNo + "\t" + musteri2.Ad + " "+ musteri2.Soyad + " adlı Müşteriye "+miktar+" TL Para Transferi Yapıldı.");
                Console.WriteLine("Güncel Bakiye : " + musteri1.Bakiye);
            }
        }
    }
}
