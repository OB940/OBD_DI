using System;

class Program
{
    public static string inversa(string cad)
    {
        string inversa = "";

        for (int c = cad.Length - 1; c >= 0; c--)
        {
            inversa += cad[c];    
        }

        return inversa;
    }

    static void Main(String[] args)
    {
        Console.Write($"> INTRODUCE UNA CADENA: ");
        string cad = Console.ReadLine();

        Console.WriteLine($"> INVERSA DE '{cad}': {inversa(cad)}");
    }
}