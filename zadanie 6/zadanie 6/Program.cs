using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, n, z, w;

        Console.WriteLine("podaj x");
        x = inputValue();
        Console.WriteLine("podaj n");
        n = inputValue();
        z = 1;
        w = 1;
        if (n > 1)
        {
            w = n * (n - 1);
            if (x == w)
            {
                Console.WriteLine(w);
            }
            else
            {
            }
        }
        else
        {
            w = 1;
            if (x == w)
            {
                Console.WriteLine(w);
            }
            else
            {
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
