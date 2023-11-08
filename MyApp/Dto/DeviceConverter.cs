using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebApp.Dto;

public class DeviceConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override bool CanWrite => false;

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);

        // Using a nullable bool here in case "is_album" is not present on an item
        int? DeviceType_Id = (int?)jo["DeviceType_Id"];

        DeviceDto item;
        if (DeviceType_Id == 1)
        {
            item = new SocketDto();
        }
        else if (DeviceType_Id == 2)
        {
            item = new LuminaireDto();
        }
        else
        {
            item = new ThermostatDto();
        }

        serializer.Populate(jo.CreateReader(), item);

        return item;
    }

    public override bool CanConvert(Type objectType)
    {
        return typeof(DeviceDto).IsAssignableFrom(objectType);
    }
}