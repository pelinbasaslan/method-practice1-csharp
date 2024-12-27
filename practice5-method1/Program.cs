void WriteTheLyric()
{
    Console.WriteLine("I'm not living, I'm just killing time");
}

int RandomSayiMod2Kalan()
{
    Random rnd = new Random();
    int randomNum = rnd.Next(1, 100);
    Console.WriteLine($"random sayı: {randomNum} ");
    return randomNum % 2;
}

int Carpim(int a, int b)
{
    return a * b;
}

void Greetings(string name, string surName)
{
    Console.WriteLine($"Hoşgeldiniz, {name} {surName}!");
}

Console.WriteLine("Sevdiğim bir şarkı sözü.");
WriteTheLyric();

int kalan = RandomSayiMod2Kalan();
Console.WriteLine($"Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalan {kalan}.");

Console.WriteLine("Parametre olarak alınan iki sayının çarpımı");
int a = 4;
int b = 7;
int sonuc = Carpim(a, b);
Console.WriteLine($"Parametre olarak alınan {a} sayısı ile {b} sayısının çarpımı: {sonuc}");

Greetings("Pelin", "Başaslan");



