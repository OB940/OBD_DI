using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO: ");
        int n = int.Parse(Console.ReadLine());    

        if (n % 2 == 0)
        {
            Console.WriteLine("> " + n + " ES PAR.");
        }
        else
        {
            Console.WriteLine("> " + n + " ES IMPAR.");
        }
    }
}