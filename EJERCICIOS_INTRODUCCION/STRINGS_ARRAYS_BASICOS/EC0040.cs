using System;

class Program
{
    static void Main(String[] args)
    {
        int[] nums = new int[5];

        for (int c = 0; c < nums.Length; c++)
        {
            Console.Write($"> [{c + 1}] INTRODUCE UN NÚMERO ENTERO: ");
            nums[c] = int.Parse(Console.ReadLine());
        }

        Console.Write("[ ");

        for (int c = 0; c < nums.Length; c++)
        {
            Console.Write(nums[c]);
            
            if (c < nums.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.Write(" ]");
    }
}