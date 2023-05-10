using System;

namespace Developer5
{
    public class NegativeGoal : Goal
    {
        private int penalty;

        public NegativeGoal(string name, string description, int points, bool isCompleted, int penalty) : base(name, description, points, isCompleted)
        {
            this.penalty = penalty;
        }

        // RecordEvent method for NegativeGoal
        public override int RecordEvent()
        {
            Console.WriteLine("Did you perform the negative action? (yes/no)");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                IsCompleted = true;
                return -penalty;
            }
            else
            {
                return 0;
            }
        }

        // SaveData method for NegativeGoal
        public override string SaveData()
        {
            return $"NegativeGoal|{Name}|{Description}|{Points}|{IsCompleted}|{penalty}";
        }
    }
}