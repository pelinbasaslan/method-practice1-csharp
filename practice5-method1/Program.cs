using System;

class Program
{
   static void Main(string[] args)
   {
        //1.Geriye Değer Döndürmeyen Bir void metot. Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
        WriteTheLyric();
        //2.Geriye Tamsayı Döndüren Bir metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
        int kalan = RandomSayiMod2Kalan();
        Console.WriteLine(kalan);
        //3.Parametre Alan ve Geriye Değer Döndüren Bir Metot.Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
        int a = 4;
        int b = 7;
        Carpim(a, b);
        Console.WriteLine(Carpim(a,b));
        //4.Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
        Greetings("Pelin","Başaslan");
   }

   //1.Geriye Değer Döndürmeyen Bir void metot. Ekrana sevdiğiniz bir şarkı sözünü yazdırsın.
   static void WriteTheLyric()
   {
        Console.WriteLine("I'm not living, I'm just killing time");
   }

   //2.Geriye Tamsayı Döndüren Bir metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

   static int RandomSayiMod2Kalan()
   {
        Random rnd = new Random();
        int randomNum = rnd.Next(1, 100);
        System.Console.WriteLine($"Bilgisayarın rastgele ürettiği sayı: {randomNum}");
        return randomNum % 2;
   }

    //3.Parametre Alan ve Geriye Değer Döndüren Bir Metot.Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
    static int Carpim(int a, int b)
    {
        return a * b;
    }

    //4.Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
    static void Greetings(string name, string surName)
    {
        Console.WriteLine($"Hoşgeldiniz, {name} {surName}!");
    }


}