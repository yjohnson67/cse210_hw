using System;
using System.Collections.Generic;

namespace Learning04
{
    //Abstract class called Assignment
    abstract class Assignment
    {
        //Properties of the Assignment class
        public string Title { get; set; }
        public string Author { get; set; }

    //Abstract method called GetAssignmentInfo() that returns a string
        public abstract string GetAssignmentInfo();
    }
}