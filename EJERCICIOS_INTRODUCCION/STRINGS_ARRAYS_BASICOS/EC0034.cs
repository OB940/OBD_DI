using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> INTRODUCE UNA CADENA: ");
        string cad = Console.ReadLine();

        char primero = cad[0];
        char ultimo = cad[cad.Length - 1];

        Console.WriteLine($"> PRIMER CARÁCTER: {primero} \n> ÚLTIMO CARACTER: {ultimo}");
    }
}