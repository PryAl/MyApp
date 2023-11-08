using Newtonsoft.Json;

namespace WebApp.Dto;

[JsonConverter(typeof(DeviceConverter))]
public class DeviceDto
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Room_Id { get; set; }
    public int DeviceType_Id { get; set; }
}

public class SocketDto : DeviceDto
{
    public int Outlets_count { get; set; }
}

public class LuminaireDto : DeviceDto
{
    public int Wattage { get; set; }
}

public class ThermostatDto : DeviceDto
{
    public int Temperature { get; set; }
}