namespace Domain.Entities;
public class RoomEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Floor { get; set; }
    public int Temperature { get; set; }
    public int Humidity { get; set; }
}

