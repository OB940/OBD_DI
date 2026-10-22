using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("= = = [ CALCULADORA DE METROS A MILLAS ] = = =");
        Console.Write("> METROS: ");
        double metros = double.Parse(Console.ReadLine());

        double calcMillas = metros / 1609;

        if (metros == 1.0)
        {
            Console.WriteLine($"> {metros} metro equivale a {calcMillas} MILLAS. ");
        }
        else
        {
            Console.WriteLine($"> {metros} metros equivalen a {calcMillas} MILLAS. ");
        }
    }
}