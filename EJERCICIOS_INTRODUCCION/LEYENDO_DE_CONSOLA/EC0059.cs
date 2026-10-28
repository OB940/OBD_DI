using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> PRECIO (SIN IVA): ");
        double p = Double.Parse(Console.ReadLine());

        Console.WriteLine("> PRECIO CON IVA: " + (p * 1.21));
    }
}