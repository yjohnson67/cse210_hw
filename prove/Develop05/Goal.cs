using System;

namespace Developer5
{
    public abstract class Goal
    {
        private string name;
        private string description;
        private int points;
        private bool isCompleted;

        //Private fields

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public string Description
        {
            get { return description; }
            protected set { description = value; }
        }

        public int Points
        {
            get { return points; }
            protected set { points = value; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            protected set { isCompleted = value; }
        }

        // GetGoalInfo method
        public void GetGoalInfo()
        {
            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points this goal is worth?");
            points = int.Parse(Console.ReadLine());
        }

        //constructors

        public Goal(string name, string description, int points)
        {
            this.name = name;
            this.description = description;
            this.points = points;
            this.isCompleted = false;
        }

        public Goal(string name, string description, int points, bool isCompleted)
        {
            this.name = name;
            this.description = description;
            this.points = points;
            this.isCompleted = isCompleted;
        }

        //GetIsCompleted method

        public char GetIsCompleted()
        {
            return isCompleted ? 'X' : ' ';
        }

        //DisplayGoal method

        public virtual string DisplayGoal()
        {
            return $"[{GetIsCompleted()}] {name} ({description})";
        }

        // DisplayCompletedGoal method

        public virtual string DisplayCompletedGoal()
        {
            return $"{name} ({description})";
        }

        // Abstract methods

        public abstract string SaveData();

        public abstract int RecordEvent();
    }
}