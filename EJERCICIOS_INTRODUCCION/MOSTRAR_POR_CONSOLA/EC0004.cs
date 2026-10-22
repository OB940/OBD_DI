using System;

class Program
{
    static void Main(String[] args)
    {
        double primera = (-8 + 6 * 3);
        double segunda = ((2 + 7) % 5);
        double tercera = (2 + (-1 * 8) *-5 % 3 );


        Console.WriteLine("> PRIMERA OPERACIÓN (-8 + 6 * 3): " + primera );
        Console.WriteLine("> SEGUNDA OPERACIÓN ( (2 + 7) % 5 ): " + segunda );
        Console.WriteLine("> TERCERA OPERACIÓN ( 2 + (-1 * 8) - 5 % 3 ): " + tercera);
    }
}