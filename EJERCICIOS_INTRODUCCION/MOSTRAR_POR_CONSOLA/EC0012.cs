using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(String[] args)
    {
        int numA = 129070;
        int numB = 20689;
        int resultado = numA*numB;

        Console.WriteLine("> RESULTADO ESPERADO: 2670329230");
        Console.WriteLine("> RESULTADO: " + resultado);

        Console.WriteLine("EL PROBLEMA ES QUE LAS VARIABLES DE TIPO 'INT' NO PUEDEN ALMACENAR TANTOS DÍGITOS/BITS. POR LO QUE ESTA OPERACIÓN SÍ FUNCIONARÍA SI LAS VARIABLES FUESEN DE TIPO 'LONG'");
    
    }
}