using System;

class Program
{
    public static void elevarRecursivamente(int n, int potencia)
    {
        int c = 1;
        int res = 0;
        string resConsola = n + "";

        while (c != potencia)
        {
            res += ( n * potencia );
            c++;
            resConsola += " x " + n.ToString();
        }

        Console.ReadLine($"> {n} ELEVADO A {potencia} ES: {resConsola} = {res}");
    }

    static void Main(String[] args)
    {
        Console.Write($"> INTRODUCE UN NÚMERO BASE: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"> INTRODUCE UN NÚMERO DE POTENCIA: ");
        int potencia = int.Parse(Console.ReadLine());

        elevarRecursivamente(n, potencia);
    }
}