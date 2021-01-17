using System;

namespace ClassMetodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 12345;
            musteri1.MusteriAdi = "Kadriye";
            musteri1.MusteriSoyadi = "Çakmak";
            musteri1.UyeNumarasi = 645;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 54321;
            musteri2.MusteriAdi = "Melike";
            musteri2.MusteriSoyadi = "Öztekin";
            musteri2.UyeNumarasi = 888;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 13579;
            musteri3.MusteriAdi = "Engin";
            musteri3.MusteriSoyadi = "Demirog";
            musteri3.UyeNumarasi = 777;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            //Console.WriteLine(musteri);
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + "   " + musteri.MusteriSoyadi + "   " + musteri.UyeNumarasi + musteri.MusteriId);

            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
