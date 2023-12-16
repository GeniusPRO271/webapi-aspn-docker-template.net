
using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Category
{
    WOK,
    Pizza,
    Soup,
    Desert,
    Drink
}