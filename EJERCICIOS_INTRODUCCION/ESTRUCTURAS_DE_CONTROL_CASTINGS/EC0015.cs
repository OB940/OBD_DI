using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO (n): ");
        int n = int.Parse(Console.ReadLine());    

        Console.Write("> NÚMERO (n2): ");
        int n2 = int.Parse(Console.ReadLine());    

        Console.Write("> NÚMERO (n3): ");
        int n3 = int.Parse(Console.ReadLine());    

        Console.WriteLine("> MÁXIMO: " + Math.Max(n, Math.Max(n2, n3)) + " | MÍNIMO: " + + Math.Min(n, Math.Min(n2, n3)));
    }
}