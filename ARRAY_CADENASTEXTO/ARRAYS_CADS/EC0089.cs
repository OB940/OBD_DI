using System;
// WIP
class Program
{
    static void Main(String[] args)
    {
        double[] array = new double[10];
        double suma = 0;
        double moda = array[0];

        for (int c = 0; c < array.Length; c++)
        {
            Console.Write($"> [{c + 1}] - INTRODUCE UN NÚMERO (DOUBLE): ");
            double n = double.Parse(Console.ReadLine());

            array[c] = n;
            suma += array[c];
        }

        double media = (suma / array.Length);

        Console.WriteLine($"> MEDIA: {Math.Round(media, 2)}");
    }
}