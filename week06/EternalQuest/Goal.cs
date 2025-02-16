namespace EternalQuest
{
    public abstract class Goal
    {
        private string _name { get; set; }
        private string _description { get; set; }
        private int _points { get; set; }

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete(); 
        public abstract string GetStringRepresentation();

        public virtual string GetDetailsString()
        {
            return $"{_name} - {_description}";
        }

    }
}