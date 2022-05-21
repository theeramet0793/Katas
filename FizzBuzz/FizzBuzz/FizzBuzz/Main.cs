
namespace FizzBuzzNamespace;
public class FizzBuzzMain
{
    public static void Main()
    {
        FizzBuzz FB = new FizzBuzz();

        for (int i = 1; i < 101; i++)
        {
            Console.Write( $"{FB.FizzOrBuzz(i)} ");
        }

        Console.WriteLine();
        Console.WriteLine($"{FB.FizzOrBuzz("adfhjkdjaflkjdlf354869058605553345/***-*-")} ");
        Console.ReadLine();
    }
}
