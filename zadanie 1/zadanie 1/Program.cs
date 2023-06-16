using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double podstawa, wykładnik;

        Console.WriteLine("podaj podstawę");
        podstawa = inputValue();
        Console.WriteLine("podaj wykładnik");
        wykładnik = inputValue();
        double wynik;

        wynik = 1;
        while (wykładnik > 0)
        {
            wynik = wynik * podstawa;
            wykładnik = wykładnik - 1;
        }
        Console.WriteLine(wynik);
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
