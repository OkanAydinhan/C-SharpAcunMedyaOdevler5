using Odev1;

public class Program
{
    public static void Main()
    {
        Marka bmw = new Marka("BMW");
        Kapi kapi = new Kapi(4);
        Pencere pencere = new Pencere(4);
        Kasa kasa = new Kasa("sedan");

        Araba bmwX5 = new Araba(bmw, "320i", kapi, pencere, kasa, 2000000);
        bmwX5.BilgileriYazdir();
    }
}
