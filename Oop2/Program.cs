using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "23132156156";

            //Kodlama.io
            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo="54321";
            musteri2.SirketAdi = "Kodalama.io";
            musteri2.VergiNo = "123546542";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3=new GercekMusteri();
            Musteri musteri4=new TuzelMusteri();

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}