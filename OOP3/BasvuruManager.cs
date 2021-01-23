using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICrediBaseManager crediBaseManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            
            crediBaseManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnbilgilendirmesiYap(List<ICrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
