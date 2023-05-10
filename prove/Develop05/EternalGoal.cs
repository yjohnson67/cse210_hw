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

        // RecordEvent method for EternalGoal
        public override int RecordEvent()
        {
            // Add display message
            return Points;
        }

        // SaveData method for EternalGoal
        public override string SaveData()
        {
            return $"EternalGoal|{Name}|{Description}|{Points}|False";
        }
    }
}