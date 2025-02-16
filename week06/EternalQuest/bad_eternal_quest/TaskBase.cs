namespace JournalApp
{
    public abstract class TaskBase
    {
        public string Description { get; set; }
        public int Points { get; set; }
        public bool IsCompleted { get; set; }

        public TaskBase(string description, int points)
        {
            Description = description;
            Points = points;
            IsCompleted = false;
        }

        public virtual void Complete()
        {
            IsCompleted = true;
            Console.WriteLine($"Task completed: {Description}. Points earned: {Points}");
        }

        public virtual string Display()
        {
            return $"{Description} - Points: {Points}, Completed: {IsCompleted}";
        }
    }
}
