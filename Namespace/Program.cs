using System;

namespace BenimNamespace
{
    public class Hesaplama
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}

//test işlemleri
namespace TestNamespace
{
    public class TestSinifi
    {
        public static void Main(string[] args)
        {
            BenimNamespace.Hesaplama hesaplayici = new BenimNamespace.Hesaplama();

            int toplamSonucu = hesaplayici.Topla(5, 3);
            int carpmaSonucu = hesaplayici.Carp(5, 3);

            Console.WriteLine($"Toplam: {toplamSonucu}");
            Console.WriteLine($"Çarpım: {carpmaSonucu}");
        }
    }
}