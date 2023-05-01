using System;

namespace Learning04
{
     // A class that represents a writing assignment that inherits from the Assignment class.
    class WritingAssignment : Assignment
    {
        // A property to get or set the genre of the writing assignment.
        public string Genre { get; set; }

        // An override method of the abstract method in the Assignment class that returns a string representation of the writing assignment.
        public override string GetAssignmentInfo()
        {
            return $"Writing - {Genre}: {Title} by {Author}";
        }
        
        //A method that returns a string representation of the genre of the writing assignment.
        public string GetWritingInformation()
        {
            return $"The genre is {Genre}";
        }
    }
}
