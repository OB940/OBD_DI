using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> INTRODUCE UNA CADENA: ");
        string cad = Console.ReadLine().ToUpper();  

        string reversa = "";

        for (int c = cad.Length - 1; c >= 0; c--)
        {
            reversa += cad[c];
        }

        if (cad.Equals(reversa))
        {
            Console.WriteLine($"> {cad} ES UN PALÍNDROMO.");
        }
        else
        {
            Console.WriteLine($"> {cad} NO ES UN PALÍNDROMO.");
        }
    }
}