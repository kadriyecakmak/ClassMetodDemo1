using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Hoşgeldiniz : " + musteriler.MusteriAdi + "  " + musteriler.MusteriSoyadi);
        }

        public void Sil(Musteri musteriler)
        {
            Console.WriteLine("Üye No bilgileriniz silinmiştir" + musteriler.UyeNumarasi);
        }

    }
}
