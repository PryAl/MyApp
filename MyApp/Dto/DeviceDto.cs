using Domain.Entities.DeviceTypes;
using JsonSubTypes;
using Newtonsoft.Json;

namespace WebApp.Dto;

[JsonConverter(typeof(JsonSubtypes), "DeviceType_Id")]
[JsonSubtypes.KnownSubType(typeof(SocketDto), 1)]
[JsonSubtypes.KnownSubType(typeof(Luminaire), 2)]
[JsonSubtypes.KnownSubType(typeof(Thermostat), 3)]
public class DeviceDto
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int? Room_Id { get; set; }
    public int DeviceType_Id { get; set; }
}