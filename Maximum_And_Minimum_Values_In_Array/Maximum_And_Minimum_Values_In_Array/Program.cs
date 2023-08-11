using System;
namespace Program
{
    public class Values
    {
        static void Main(string[]args)
        {

            Console.WriteLine("Please Enter the number of Values to be stored: ");
            int number = int.Parse(Console.ReadLine());

            int[] input = new int[number];

            for(int i=0;i<number;i++)
            {
                try
                {
                    Console.WriteLine("Please Enter the number: ");
                    input[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { Console.WriteLine("Enter the Right format"); }
            }
            int max = input[0];
            int min = input[0];
           for(int i=0;i<number;i++)
           {
                if (input[i] > max)
                    max = input[i];

                if (input[i] < min)
                    min = input[i];
           }
            Console.WriteLine($"The maximum value is {max}");
            Console.WriteLine($"The minimum value is {min}");
        }
    }
}