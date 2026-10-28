using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO ENTERO (N): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("> NÚMERO ENTERO (N): ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("> RESULTADO (N / N2): " + (n / n2) + " | RESTO: " + (n % n2));
    }
}