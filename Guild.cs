public class Guild {
    public string Name { get; private set; }
    public List<Hero> Heroes { get; private set; } = new List<Hero>();

    public Guild(string name) {
        Name = name;
    }
}