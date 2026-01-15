using System;

class Program
{
    static void Main(string[] args)
    {Console.WriteLine("What is your grade?: ");
    string gradeStr = Console.ReadLine();
    int grade = int.Parse(gradeStr);
    
    string letter = "none";

    if(grade > 90)
    { letter = "A";}

    else if(grade < 90 && grade > 80)
        {letter = "B";}



    else if(grade < 80 && grade > 70)
    { letter = "C";}

    else if(grade < 70 && grade > 60){
    letter = "D";}
    

    //{Console.WriteLine("Your grade is D");}
     

    else
    {letter = "F";} 


    int remainder = grade % 10;

    if(remainder >= 7 )
    {letter = string.Concat(letter, "+");}
    else if(remainder < 7 && remainder > 3);
    else if(remainder <= 3)
    {letter = string.Concat(letter + "-");}

    if(letter == "A+")
    {letter = "A";}

    if(letter == "F+")
    {letter = "F";}
    if(letter == "F-")
    {letter = "F";}

    Console.WriteLine(letter);

    if(grade >= 70)
    {Console.WriteLine("Congratulations you passed! ");}
    
    if(grade < 70 ) 
    {Console.WriteLine("Oh you didn't pass better luck next time. ");}}
        
    
}