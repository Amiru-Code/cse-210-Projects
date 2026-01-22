using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        
        int num;
        Random random = new Random();
        int magicNumber = random.Next(100);
        do
        {
            Console.Write("What is the magic number?: ");
            string number = Console.ReadLine();
            num = int.Parse(number);

            if(num == magicNumber)
            {
                Console.WriteLine("Congratulations that is the correct number! ");
            }

            if(num > magicNumber)
            {
            Console.WriteLine("Too high");
            }

            if(num<magicNumber)
            {
                Console.WriteLine("Too low");
            }

        } while(num != magicNumber);

        
    }
}