public class Person
{
    public int Id { get; }
    public string Name { get; }
    public string Position { get; }

    public Person(int id, string name, string position)
    {
        Id = id;
        Name = name;
        Position = position;
    }

    public override string ToString()
    {
        return $"|{Name} - {Position} - {Id}|";
    }
}