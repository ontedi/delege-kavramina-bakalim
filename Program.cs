using System;

namespace delegeler
{
    class Program
    {
        delegate void delHesaplamalar(int intSayi1, int intSayi2);
        static void Main(string[] args)
        {
            Console.WriteLine("#####################");
            Console.WriteLine("Hesaplama Başladı");
            delHesaplamalar hesap = new delHesaplamalar(fnTopla);
            hesap += fnCikar;
            hesap += fnBol;
            hesap += fnCarp;
            hesap += fnUslu;
            hesap.Invoke(5, 3);
            Console.WriteLine("Hesaplama Bitti");
            Console.WriteLine("#####################");
        }
        static void fnTopla(int intA, int intB)
        {
            Console.WriteLine("İki sayının toplam: " + (intA + intB));
        }
        static void fnCikar(int intA, int intB)
        {
            Console.WriteLine("İki sayının farkı: " + (intA - intB));
        }
        static void fnBol(int intA, int intB)
        {
            Console.WriteLine("İki sayının bölümü: " + (intA / intB));
        }
        static void fnCarp(int intA, int intB)
        {
            Console.WriteLine("İki sayının çarpımı: " + (intA * intB));
        }
        static void fnUslu(int intA, int intB)
        {
            Console.WriteLine($"{intA} ^ {intB} sonucu: " + (Math.Pow(intA, intB)));
        }
    }
}
