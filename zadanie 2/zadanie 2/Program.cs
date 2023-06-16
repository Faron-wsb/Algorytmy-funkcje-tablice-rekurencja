using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int f, n;

        Console.WriteLine("podaj numer wyrazu ciągu");
        n = (int)inputValue();
        int wynik;

        if (n <= 2)
        {
            wynik = 1;
            Console.WriteLine(wynik);
        }
        else
        {
            wynik = n - 2 + (n - 1);
            Console.WriteLine(wynik);
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

