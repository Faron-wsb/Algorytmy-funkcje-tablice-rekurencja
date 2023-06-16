using System;

public class MyProgram
{
    public static void Main(string[] args)
    {




        int n, x;
        double e = 0;
        long silnia(int n)
        {
            return n == 0 ? 1 : n * silnia(n: n - 1);

        }
        Console.WriteLine("podaj n");
       int n - Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("podaj x");
        x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            e += Math.Pow(x, i) / silnia(i);


        }

        Console.WriteLine("suma {0} pierwszych wyrazów funkcji e^x wynosi: {1}", n, e);
    }
}