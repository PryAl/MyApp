namespace Domain.Entities;

public class Room
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Premise_Id { get; set; }
    public Premise Premise { get; set; }
    public List<Device>? Devices { get; set; }
}

