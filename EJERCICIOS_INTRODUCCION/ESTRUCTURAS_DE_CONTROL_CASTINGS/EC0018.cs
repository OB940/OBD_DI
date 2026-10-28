using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO (n): ");
        double n = Double.Parse(Console.ReadLine());    

        Console.Write("> NÚMERO (n2): ");
        double n2 = Double.Parse(Console.ReadLine());    

        Console.Write("> NÚMERO (n3): ");
        double n3 = Double.Parse(Console.ReadLine());    

        double divis = ((n + n2 + n3) / 3.0);
        Console.WriteLine("> RESULTADO (N + N2 + N3) / 3.0: " + Math.Round(divis, 2));
    }
}