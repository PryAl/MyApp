using Domain.Entities.DeviceTypes;
using JsonSubTypes;
using Newtonsoft.Json;

namespace Domain.Entities;

public class Device
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public int? Room_Id { get; set; }
    public Room? Room { get; set; }
    public int DeviceType_Id { get; set; }
    public DeviceType DeviceType { get; set; }
}