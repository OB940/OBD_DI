using System;

class Program
{
    static void Main(String[] args)
    {
    
        while (true)
        {
            Console.Write("> ESCRIBE UN NÚMERO DE UNA CIFRA (PON UNO DE 2 CIFRAS PARA FINALIZAR): ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 0:
                    Console.WriteLine("> CERO.");
                    break;
                case 1:
                    Console.WriteLine("> UNO.");
                    break;
                case 2:
                    Console.WriteLine("> DOS.");
                    break;
                case 3:
                    Console.WriteLine("> TRES.");
                    break;
                case 4:
                    Console.WriteLine("> CUATRO.");
                    break;
                case 5:
                    Console.WriteLine("> CINCO.");
                    break;
                case 6:
                    Console.WriteLine("> SEIS.");
                    break;
                case 7:
                    Console.WriteLine("> SIETE.");
                    break;
                case 8:
                    Console.WriteLine("> OCHO.");
                    break;
                case 9:
                    Console.WriteLine("> NUEVE.");
                    break;
            }

            if (n >= 10)
            {
                Console.WriteLine("> CERRANDO...");
                break;
            }
        }  


    }
}