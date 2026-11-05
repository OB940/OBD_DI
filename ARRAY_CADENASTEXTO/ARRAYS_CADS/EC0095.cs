using System;

class Program
{
    static void Main(String[] args)
    {
        string[] nombres = new string[100];
        int cont = 0;
        
        for (int c = 0; c < nombres.Length; c++)
        {
            Console.Write($"[{c + 1}] - ESCRIBE UN NOMBRE");
            string nombre = Console.ReadLine();

            if (string.IsNullOrEmpty(nombre))
            {
                break;
            }

            nombres[c] = nombre;
            cont++;
        }

        Console.Write("\n[  ");
        for (int i = 0; i < cont; i++)
        {
            Console.Write(nombres[i] + "  ");
        }
        Console.Write("]");
    }
}