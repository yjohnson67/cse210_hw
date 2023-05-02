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

        public override int RecordEvent()
        {
            IsCompleted = true;
            // Add display message
            return Points;

        }

        public override string SaveData()
        {
            return $"{GetType()}|{Name}|{Description}|{Points}|{IsCompleted}";
        }
    }
}