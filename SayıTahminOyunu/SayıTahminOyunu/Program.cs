Random rastgele = new Random();
int tahmin = rastgele.Next(101);
int sayi;

while (true)
{
    Console.WriteLine("1-100 arasında bir sayi giriniz:");
    sayi = Convert.ToInt32(Console.ReadLine());

    if (tahmin > sayi)
    {
        Console.WriteLine("Daha büyük bir sayi giriniz:");

    }

    else if (tahmin < sayi)
            {
        Console.WriteLine("Daha küçük bir sayi giriniz:");

    }
     else
    {
        Console.WriteLine("Tebrikler");
    }
}

Console.ReadKey();  
