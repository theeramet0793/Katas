using System;
using System.Data;

namespace StringCalculatorNamespace;
public class MyMain
{
    public static void Main(string[] args)
    {
        //version 1
        /*while (true)
        {
            Console.Write($"Enter your string: ");
            string? str = Console.ReadLine();

            StringCalculator strCalculator = new StringCalculator();
            if (str != null)
            {
                int result = strCalculator.Add(str);

                if (result != -1)
                    Console.WriteLine(result);
            }
            Console.Write("Press any key to start again : ");
            Console.ReadKey();
            Console.WriteLine("------------------------------");
        }*/

        // version 2 

        /*string math = "1+2*5/4*8*9+6";
        string value = new DataTable().Compute(math, null).ToString();
        Console.WriteLine(value);*/

        while (true)
        {
            StringCalculator strCalculator = new StringCalculator();
            Console.Write($"\nInput expression: ");
            string? expression = Console.ReadLine();
            if(expression != null)
            {
                var result = strCalculator.Calculate(expression);
                Console.WriteLine($" = {result}");
            }          
        }
        
    }
}
