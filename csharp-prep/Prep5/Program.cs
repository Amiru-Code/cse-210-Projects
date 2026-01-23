using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        static void displayWelcome()
        {
            Console.WriteLine("Welcome to my program!");
        }

        static string askName()
        {
            Console.Write("What is your username?: ");
            string username = Console.ReadLine();
            return username;

        }

        static int promptFavoriteNumber()
        {
            Console.Write("What is your favorite number?: ");
            string number = Console.ReadLine();
            int favoriteNum = int.Parse(number);
            return favoriteNum;
        }

        static int promptUserBirthYear()
        {
            Console.Write("What is your birth year?: ");
            string stryear = Console.ReadLine();
            int birthYear = int.Parse(stryear);
            return birthYear;
        }
        
        static int squareNumber(int Number)
        {
            return Number * Number;
        }

        static void returnResults()
        {
            displayWelcome();

            string name = askName();

            int Number = promptFavoriteNumber();

            int birthyear = promptUserBirthYear();

            int numberSquare = squareNumber(Number);

            int age = 2026 - birthyear;

            Console.WriteLine($"{name}, the square of your number is {numberSquare}");
            
            Console.WriteLine($"{name}, you are turning {age} this year ");

            

        
        }

        returnResults();
    }
}