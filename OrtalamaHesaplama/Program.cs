/*
Ödev: Kullanıcıdan 5 adet sayı alarak bu sayıların ortalamasını hesaplayan bir program yazın.

Yapılması Gerekenler:

Kullanıcıdan 5 tane sayı girişi alın ve bir diziye kaydedin.
for veya foreach döngüsünü kullanarak tüm sayıların toplamını bulun.
Toplamı 5’e bölerek ortalamayı hesaplayın.
Sonucu ekrana yazdırın.
*/

using System;

public class OrtalamaHesaplama
{
    public static void Main(string[] args)
    {
        int[] sayilar = new int[5]; 

        
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }

       
        float ortalama = (float)toplam / 5;

        
        Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
    }
}