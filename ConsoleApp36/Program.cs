using System;
using System.IO;

class Program
{
    static void Main()
    {
        int[] numbers = new int[24];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            int total = 0;
            foreach (int number in numbers)
            {
                int doubledNumber = number * 2;
                writer.WriteLine(doubledNumber);

                total += doubledNumber;
            }

            writer.Close();

            Console.WriteLine("Ədədlərin cəmi: " + total);
        }
    }
}
