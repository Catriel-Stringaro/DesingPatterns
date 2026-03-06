// Used in the WITHOUT PROTOTYPE example.
// This class has no clone support — copying it manually
// still shares the same Skills list reference.
public class PlayerConfig
{
    public string Name { get; set; }
    public int Level { get; set; }
    public List<string> Skills { get; set; }

    public PlayerConfig(string name, int level, List<string> skills)
    {
        Name = name;
        Level = level;
        Skills = skills;
    }
}
