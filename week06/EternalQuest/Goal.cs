/*Name the class*/
public class Goal
{
    /*Define attributes*/
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }


    /*Define constructor  (constructor/function) */
    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }
}


