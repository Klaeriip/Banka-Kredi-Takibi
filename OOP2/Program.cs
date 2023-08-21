using OOP2;

namespace Oop2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Efekan Ulubaş

            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Adi = "Efekan";
            musteri1.Soyadi = "Ulubaş";
            musteri1.Id = 1;
            musteri1.TcNo = "2222222222222";
            musteri1.MusteriNo = "12345";
            musteri1.SirketAdi = "?";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "7654321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add (musteri1);
            musteriManager.Add (musteri2);

        }


    }







}