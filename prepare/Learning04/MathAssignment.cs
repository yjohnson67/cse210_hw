using System;

namespace Learning04
{
    // Declare the MathAssignment class which extends the Assignment abstract class
    class MathAssignment : Assignment
    {
        //Declare the Topic property
        public string Topic { get; set; }

         // Override the GetAssignmentInfo method to return a string with assignment info
        public override string GetAssignmentInfo()
        {
            return $"Math - {Topic}: {Title} by {Author}";
        }

        //Declare the GetHomeworkList method which returns a list of strings
        public List<string> GetHomeworkList()
        {
            //Return a new List object withhomework assignments
            return new List<string>() {
                "Chapter 2: Fractions",
                "Chapter 3: Decimals",
                "Chapter 4: Algebra",
                "Chapter 5: Geometry"
            };
        }
    }
}