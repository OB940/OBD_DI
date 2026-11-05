using System;

class Program
{
    static void Main(String[] args)
    {
        int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        string[] meses = { 
            "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", 
            "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" 
        };

        int dia = 0;
        int mes = 0;
        int diaDelAño = 0;

        Console.WriteLine("= = = = [ CALCULADORA DE DÍAS DEL AÑO ] = = = =");
        Console.Write(">");
        for (int c = 0; c < meses.Length; c++)
        {
            if (meses[c].Equals("DICIEMBRE"))
            {
                Console.Write($" {meses[c]} => {dias[c]}");
            }
            else
            {
                Console.Write($" {meses[c]} => {dias[c]} ;");
            }
        }

        while (mes < 1 || mes > 12)
        {
            Console.Write($"\n> INTRODUCE UN NÚMERO DE MES (1-12): ");
            mes = int.Parse(Console.ReadLine()); 
        }

        while (dia < 1 || dia > dias[mes - 1])
        {
            Console.Write($"> INTRODUCE UN NÚMERO DE DÍA DE DICHO MES (TEN EN CUENTA EL ÚLTIMO DÍA): ");
            dia = int.Parse(Console.ReadLine());
        }

        for (int c = 0; c < mes - 1; c++)
        {
            diaDelAño += dias[c];      
        }

        diaDelAño += dia;

        Console.WriteLine($"EL MES DE {meses[mes]} ES EL DÍA Nº{diaDelAño} DEL AÑO. ");
    }
}