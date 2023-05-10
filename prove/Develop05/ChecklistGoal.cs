using System;
using System.Collections.Generic;

namespace Developer5
{
    public class ChecklistGoal : Goal
    {
        private int target;
        private int bonus;
        private int total;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            this.target = target;
            this.bonus = bonus;
            total = 0;
        }

        public ChecklistGoal(string name, string description, int points, bool isCompleted, int target, int bonus) : base(name, description, points, isCompleted)
        {
            this.target = target;
            this.bonus = bonus;
            total = 0;
        }

        public override int RecordEvent()
        {
            Console.WriteLine("How many times did you complete the goal?");
            int amount = int.Parse(Console.ReadLine());
            total += amount;
            if(total >= target)
            {
                IsCompleted = true;
                return bonus + (amount * Points);
            }
            else
                return amount * Points;
           

        }

        public override string SaveData()
        {
            return $"ChecklistGoal|{Name}|{Description}|{Points}|{IsCompleted}|{target}|{bonus}|{total}";
        }
    }
}