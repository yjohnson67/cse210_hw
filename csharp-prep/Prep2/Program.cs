using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

          
        Console.Write("Enter your grade percentage: ");
        double grade = double.Parse(Console.ReadLine());

        string letter;

        if (grade >= 90 && grade <= 100)
        {
            letter = "A";
            if (grade >= 97)
            {
                letter += "+";
            }
            else if (grade <= 93)
            {
                letter += "-";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (grade >= 87)
            {
                letter += "+";
            }
            else if (grade <= 83)
            {
                letter += "-";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (grade >= 77)
            {
                letter += "+";
            }
            else if (grade <= 73)
            {
                letter += "-";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (grade >= 67)
            {
                letter += "+";
            }
            else if (grade <= 63)
            {
                letter += "-";
            }
        }
        else
        {
            letter = "F";
            if (grade < 60)
            {
                grade = 60;
            }
        }

        Console.WriteLine("Your letter grade is: " + letter);

        if (letter != "F")
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}