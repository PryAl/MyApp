namespace WebApp.Dto;
public class RoomDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Floor { get; set; }
    public int Temperature { get; set; }
    public int Humidity { get; set; }
    public bool Light { get; set; }
}
