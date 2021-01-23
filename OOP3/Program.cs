using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediBaseManager ihtiyacCrediManager = new İhtiyacCrediManager();     
            ICrediBaseManager tasitCrediManager = new TasitCrediManager();
            ICrediBaseManager konutCrediManager = new KonutCrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<ICrediBaseManager> krediler = new List<ICrediBaseManager>() {ihtiyacCrediManager,tasitCrediManager,konutCrediManager };

            basvuruManager.KrediOnbilgilendirmesiYap(krediler);
        }
    }
}
