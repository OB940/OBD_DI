using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO ENTERO: ");
        int n = int.Parse(Console.ReadLine());

        n = Math.Abs(n % 10);

        Console.WriteLine("> ÚLTIMO DÍGITO: " + n);
    }
}