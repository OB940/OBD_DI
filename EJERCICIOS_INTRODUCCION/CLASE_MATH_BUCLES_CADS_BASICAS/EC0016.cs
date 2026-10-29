using System;

class Program
{
    static void Main(String[] args)
    {
        while (true)
        {
            int num;
            Console.Write("> INTRODUCE UN NÚMERO ENTERO: ");
            string n = Console.ReadLine();   
            
            // CONVIERTO LA CADENA A INT (NUM), SI FUNCIONA, ENTONCES CIERRO EL PROGRAMA
            if (int.TryParse(n, out num))
            {
                Console.WriteLine("> MUCHAS GRACIAS POR TU COLABORACIÓN.");
                Console.WriteLine("> CERRANDO...");
                break;
            }
            else
            {
                Console.WriteLine("> ERROR. VALOR INTRODUCIDO NO ES UN Nº ENTERO.");
            }
        }



    }
}