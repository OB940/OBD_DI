using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> ¿CÓMO TE LLAMAS?: ");
        String nombre = Console.ReadLine();

        Console.WriteLine("HOLA, " + nombre.ToUpper() + ".");
    }
}