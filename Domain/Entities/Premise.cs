namespace Domain.Entities;

public class Premise
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Floor { get; set; }
    public List<Room>? Rooms { get; set; }
}