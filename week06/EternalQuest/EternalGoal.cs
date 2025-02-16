using EternalQuest;

    public class EternalGoal(string name, string description, int points)
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