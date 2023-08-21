using System.Collections.Generic;

namespace OOP3  
{
    class Program
    {
       

        static void Main(string[] args) 
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();        
            IKrediManager tasitKrediManager = new TasitKrediManager();           
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();
           

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerServices = new SmsLoggerServices();

            BasvuruManager basvuruManager = new BasvuruManager();

            new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerServices() };

        

           List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
 
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


             

        }


    }


}

