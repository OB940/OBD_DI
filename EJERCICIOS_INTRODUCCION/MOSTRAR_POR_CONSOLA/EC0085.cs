using System;

class Program
{
    static void Main(String[] args)
    {
        int a = 3;
        Console.WriteLine("A = " + a);

        int b = ++a;
        Console.WriteLine("B = " + b);

        int c = a++;
        Console.WriteLine("C = " + c);

        b = b * 3;
        a = a * 2;

        Console.WriteLine("B (NUEVO) = " + b);
        Console.WriteLine("A (NUEVO) = " + a);

    }
}
