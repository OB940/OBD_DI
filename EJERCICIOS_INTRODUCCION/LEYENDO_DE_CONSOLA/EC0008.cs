using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO ENTERO (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("> NÚMERO ENTERO (n2): ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("[FORMATO (a + b = resultado)]: " + n + " + " + n2 + " = " + (n + n2));
    }
}