using System;

namespace Developer5
{
    public class ProgressGoal : Goal
    {
        private int target;
        private int progress;

        public ProgressGoal(string name, string description, int points, bool isCompleted, int target, int progress) : base(name, description, points, isCompleted)
        {
            this.target = target;
            this.progress = progress;
        }

        public override int RecordEvent()
        {
            Console.WriteLine("How much progress did you make towards the goal?");
            int amount = int.Parse(Console.ReadLine());
            progress += amount;

            if (progress >= target)
            {
                IsCompleted = true;
                return Points;
            }
            else
            {
                return 0;
            }
        }

        public override string SaveData()
        {
            return $"ProgressGoal|{Name}|{Description}|{Points}|{IsCompleted}|{target}|{progress}";
        }
    }
}