using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO: ");
        int n = int.Parse(Console.ReadLine());
        
        int sumaFor = 1;
        int sumaForEach = 1;

        for (int c = 0; c <= n; c++)
        {
            sumaFor += c;
        }

        Console.WriteLine("> SUMA_FOR: " + sumaFor);

        
    }
}