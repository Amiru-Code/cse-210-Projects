using System;
using System.Globalization;
using System.Collections.Generic;
using System.Runtime.InteropServices;


class Program
{
    static void Main()
    {
        
        int num = 0;
        List<int> numbers = new List<int>();
        
        
        

        do
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            numbers.Add(num);
        }
        while (num != 0);
        
        numbers.Remove(0);

        int finalSum = 0;
        int largeNum = 0;
                
        foreach(int n in numbers)
        {
            finalSum += n;
            if(n>largeNum)
                largeNum = n;
            
        }
        
        float floatFinalSum = (float)finalSum;

        float avg = floatFinalSum / numbers.Count;




        
        Console.WriteLine($"The sum is {finalSum}, the average is {avg},  the largest number is {largeNum}");

        
    }
}