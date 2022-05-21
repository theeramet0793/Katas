using PrimeComposite;
using System;

class Mymain
{
    public static void Main()
    {
        var primeCompositeEvenChecker = new PrimeCompositeEvenChecker();
        for (int i = 1; i <= 100; i++)
        {
            var result =primeCompositeEvenChecker.Check(i);
            Console.Write($"{result}    ");
        }
        Console.ReadLine();
    }
}

