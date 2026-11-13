using System;
using System.Security.Cryptography.X509Certificates;

public struct Persona
{
    // VARIABLES DEL STRUCT
    public string Nombre { get; set; }
    public long DNI { get; set; }
    public char LetraDNI { get; set;}
    public int Edad { get; set; }
    
    public static Persona crearPersona()
    {
        Persona p = new Persona();

        Console.Write($"> INTRODUCE EL NOMBRE DE LA PERSONA: ");
        p.Nombre = Console.ReadLine();

        Console.Write($"> INTRODUCE EL DNI (SOLO LOS NÚMEROS): ");
        p.DNI = long.Parse(Console.ReadLine());

        Console.Write($"> INTRODUCE LA LETRA DEL DNI: ");
        p.LetraDNI = char.ToUpper(char.Parse(Console.ReadLine()) );

        Console.Write($"> INTRODUCE LA EDAD (SIN DECIMALES OBVIAMENTE): ");
        p.Edad = int.Parse(Console.ReadLine());

        return p;
    }

    /*
    public Persona(int nombre, long dni, char letraDNI, int edad)
    {
        Nombre = nombre;
        DNI = dni;
        LetraDNI = letraDNI;    
        Edad = edad;
    }
    */

    
}
class Program
{
    static void Main(String[] args)
    {
        
    }
}