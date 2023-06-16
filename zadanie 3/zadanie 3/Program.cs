using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, k, m;

        Console.WriteLine("podaj n <5");
        n = (int)inputValue();
        Console.WriteLine("podaj k<5");
        k = (int)inputValue();
        int nsilnia, ksilnia;

        if (n < 5)
        {
            Console.WriteLine("n jest mniejsze niż 5");
        }
        else
        {
            while (n > 1)
            {
                nsilnia = n * (n - 1);
            }
            if (k < 5)
            {
                Console.WriteLine("k jets mniejsze niż 5");
            }
            else
            {
                while (k > 1)
                {
                    ksilnia = k * (k - 1);
                }
                double wynik;

                wynik = (double)(nsilnia - ksilnia) / ksilnia;
                Console.Write("wynik równania to");
                Console.WriteLine(wynik);
            }
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

    }z
    
    