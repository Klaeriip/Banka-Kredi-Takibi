using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{                                                             //Method injection
    internal class BasvuruManager
    {
        internal static void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices);
       
        public void BasvuruYap(IKrediManager krediManager, ILoogerService loggerServices) 
        {
            // Başvuru bilgilerini değerlendirme 

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }

    }
}
