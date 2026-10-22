using System;

class Program
{
    static void Main(String[] args)
    {
        int _1entero = 321;
        int _2entero = 698;
        double resultado = (double)_1entero / _2entero;

        Console.WriteLine($"RESULTADO (321/698): {Math.Round(resultado, 3)}");
    }
}