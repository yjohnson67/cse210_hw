//Import the System namespace, which contains the Console class we need to output text using System;
using System;

//Declare the Learning04namespace
namespace Learning04
{

    //Declare the Program class
    class Program
    {
        //Declare the Main method, the entry point for the program
        static void Main(string[] args)
        {
            //Create a new instance of the MathAssignment class, and initialize its properties
            MathAssignment assignment1 = new MathAssignment()
            {
                Title = "Multiplication",
                Author = "Samuel Bennett",
                Topic = "Arithmetic"
            };

            // Print out information about the assignment to the console using the GetAssignmentInfo method
            Console.WriteLine(assignment1.GetAssignmentInfo());


             // Print out the homework list for the assignment to the console using the GetHomeworkList method
            Console.WriteLine("Homework list:");
            foreach (string homework in assignment1.GetHomeworkList())
            {
                Console.WriteLine($"- {homework}");
            }
            Console.WriteLine();

             // Create a new instance of the WritingAssignment class, and initialize its properties
            WritingAssignment assignment2 = new WritingAssignment()
            {
                Title = "The Causes of World War II",
                Author = "Mary Waters",
                Genre = "European History"
            };

             // Print out information about the assignment to the console using the GetAssignmentInfo and GetWritingInformation methods
            Console.WriteLine(assignment2.GetAssignmentInfo());
            Console.WriteLine(assignment2.GetWritingInformation());
            Console.WriteLine();

            // Create a new instance of the MathAssignment class, and initialize its properties
            MathAssignment assignment3 = new MathAssignment()
            {
                Title = "Fractions",
                Author = "Roberto Rodriguez",
                Topic = "Arithmetic"
            };

            // Print out information about the assignment to the console using the GetAssignmentInfo method
            Console.WriteLine(assignment3.GetAssignmentInfo());
        }
    }
}
