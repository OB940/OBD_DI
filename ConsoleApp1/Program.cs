class Program
{
    static void Main(String[] args)
    {
        double n = 6.75412345;
        Console.WriteLine("= = = = [ NÚMERO ORIGINAL ] = = = =");
        Console.WriteLine(" > " + n);

        Console.WriteLine("\n" + "= = = = [ MOSTRANDO TRES DECIMALES ] = = = =");
        Console.WriteLine($" > {n:F3}");

        String input = "67410";
        int num = int.TryParse(input, out num) ? num : 0;
    }
}
