using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Araba
    {
        public Marka Marka;
        public string Model;
        public Kapi Kapi;
        public Pencere Pencere;
        public Kasa Kasa;
        public decimal Fiyat;

        public Araba(Marka marka, string model, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Kapi = kapi;
            Pencere = pencere;
            Kasa = kasa;
            Fiyat = fiyat;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine("Arabanın markası : "+ Marka.MarkaAdi + " modeli : "+Model+" kapı sayısı : "+Kapi.KapiSayisi+" pencere sayısı : "+Pencere.PencereSayisi+" kasası : "+Kasa.KasaTipi+" fiyatı : "+Fiyat+" TL’dir.");
        }
    }
}
