using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Yılmaz";
            musteri1.Soyad = "Tek";
            musteri1.Yas = 35;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Nevin";
            musteri2.Soyad = "Türk";
            musteri2.Yas = 26;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Murat";
            musteri3.Soyad = "Topal";
            musteri3.Yas = 57;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};
            
            MusteriManager musteriManager = new MusteriManager();
            
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID:"+musteri.Id);
                Console.WriteLine("Müşteri Ad:" + musteri.Ad);
                Console.WriteLine("Müşteri Soyad:" +musteri.Soyad);
                Console.WriteLine("Müşteri Yaş" +musteri.Yas);
                Console.WriteLine("-------------------");
            }
           
            foreach (var musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
                musteriManager.MusteriListele(musteri);
                musteriManager.MusteriSilme(musteri);
                Console.WriteLine("---------");
            }


        }
    }
}
