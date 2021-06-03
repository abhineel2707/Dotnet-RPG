using System.Text.Json.Serialization;

namespace RPG_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric

    }
}