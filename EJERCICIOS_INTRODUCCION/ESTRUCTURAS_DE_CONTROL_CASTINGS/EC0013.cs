using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO (n): ");
        int n = int.Parse(Console.ReadLine());    

        Console.Write("> NÚMERO (n2): ");
        int n2 = int.Parse(Console.ReadLine());    

        if (n > n2)
        {
            Console.WriteLine("> " + n + " ES MAYOR QUE " + n2);
        }
        else
        {
            Console.WriteLine("> " + n2 + " ES MAYOR QUE " + n);
        }

        if (n == n2)
        {
            Console.WriteLine("> AMBOS NÚMEROS SON IGUALES.");
        }
    }
}