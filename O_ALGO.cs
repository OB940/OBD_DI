using System;

class Program
{
    static void Main(String[] args)
    {
        int[] num = new int[10];
        int cont = 1;

        for (int c = 0; c < num.Length; c++)
        {
            Console.Write($"> INTRODUCE UN NÚMERO ({c + 1}): ");
            num[c] = int.Parse(Console.ReadLine());
        }

        for (int c = 0; c < num.Length - 1; c++)
        {
            for (int i = c + 1; i < num.Length; i++)
            {
                if (num[c].Equals(num[i]))
                {
                    cont++;
                    Console.WriteLine($"> EL NÚMERO {num[i]} APARECE {cont} VECES.");
                }
            }
        }
    }
}