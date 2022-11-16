using System;
using System.Text.Json.Serialization;

public class Pokemon
{
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("weight")]
    public int weight { get; set; }

    [JsonPropertyName("is_default")]
    public bool isDefault { get; set; }
}
