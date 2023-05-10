namespace Developer5
{

    class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {

        }

        public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
        {

        }

        // public override int RecordEvent()

        // This comment indicates that the following code block overrides the RecordEvent method from the base class.

        public override int RecordEvent()
        {
            IsCompleted = true;
            // Add display message
            return Points;

        }

        // public override string SaveData()

        // This comment indicates that the following code block overrides the SaveData method from the base class.

        public override string SaveData()
        {
            return $"SimpleGoal|{Name}|{Description}|{Points}|{IsCompleted}";
        }
    }
}