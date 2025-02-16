using EternalQuest;

    public class ChecklistGoal(string name, string description, int points)
        : base(name, description, points){}

    public override void RecordEvent()
    {

    }
    public override bool IsComplete {get : set;} = false
    {
        return false;

    }
    public override string GetStringRepresentation()
    {
     
    }