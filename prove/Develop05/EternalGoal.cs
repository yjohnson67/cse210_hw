using System;

namespace Developer5
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public EternalGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
        {
        }

        public override int RecordEvent()
        {
            // Add display message
            return Points;
        }

        public override string SaveData()
        {
            return $"{GetType()}|{Name}|{Description}|{Points}";
        }
    }
}