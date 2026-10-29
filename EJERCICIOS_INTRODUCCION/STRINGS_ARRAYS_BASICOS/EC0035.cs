using System;
using System.Globalization;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> INTRODUCE UNA CADENA: ");
        string cad = Console.ReadLine().ToUpper();

        int cont = 0;
        for (int c = 0; c < cad.Length; c++)
        {
            if (cad[c] == 'A' || cad[c] == 'E' || cad[c] == 'I' || cad[c] == 'O' || cad[c] == 'U')
            {
                cont += 1;
            }
        }

        Console.WriteLine($"> LA CADENA {cad} TIENE {cont} VOCALES");
    }
}