using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x;
        int z;
        z = 0;

        Console.WriteLine("wpisz liczbe ujemną, jeśli propozycja jest mniejsza od szukanej liczby");
        Console.WriteLine("wpisz liczbą dodatnią, jeśli propozycja jest większa od szukanej liczby");
        Console.WriteLine("wpisz zereo jeśli algorytm odgadł liczbę");
        x = 10;
        Console.Write("czy twoja liczba to:");
        Console.WriteLine(x);
        double y;

        y = inputValue();
        

        if (y == 0)
        {
            Console.Write("twoja liczba to:");
            Console.WriteLine(x);
        }
        else
        {
            if (y > 0)
            {
                while (y != 0)
                {
                    z = x + 1;
                    x = (int)z;
                    Console.Write("czy twoja liczba to:");
                    Console.WriteLine(z);
                    y = inputValue();
                }
                Console.Write("twoja liczba to:");
                Console.WriteLine(z);
            }
            else
            {
                while (y != 0)
                {
                    z = x - 1;
                    x = (int)z;
                    Console.Write("czy twoja liczba to:");
                    Console.WriteLine(z);
                    y = inputValue();
                }
                Console.Write("twoja liczba to:");
                Console.WriteLine(z);
            }
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
