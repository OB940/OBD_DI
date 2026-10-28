using System;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("> NÚMERO (n): ");
        double n = Double.Parse(Console.ReadLine());    

        Console.Write("> NÚMERO (n2): ");
        double n2 = Double.Parse(Console.ReadLine());    

        double divis = (n / n2);

        if (n == 0 || n2 == 0)
        {
            Console.WriteLine("> ERROR. DIVISIÓN NO VÁLIDA (UNO DE LOS NÚMEROS ES 0).");
        }
        else
        {
            Console.WriteLine("> RESULTADO: " + divis);
        }
    }
}