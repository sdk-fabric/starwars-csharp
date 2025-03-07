/**
 * Species automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Starwars;

/// <summary>
/// A Species is a type of person or character within the Star Wars Universe
/// </summary>
public class Species
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    [JsonPropertyName("designation")]
    public string? Designation { get; set; }

    [JsonPropertyName("average_height")]
    public string? AverageHeight { get; set; }

    [JsonPropertyName("average_lifespan")]
    public string? AverageLifespan { get; set; }

    [JsonPropertyName("eye_colors")]
    public string? EyeColors { get; set; }

    [JsonPropertyName("hair_colors")]
    public string? HairColors { get; set; }

    [JsonPropertyName("skin_colors")]
    public string? SkinColors { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("homeworld")]
    public string? Homeworld { get; set; }

    [JsonPropertyName("people")]
    public System.Collections.Generic.List<string>? People { get; set; }

    [JsonPropertyName("films")]
    public System.Collections.Generic.List<string>? Films { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("created")]
    public System.DateTime? Created { get; set; }

    [JsonPropertyName("edited")]
    public System.DateTime? Edited { get; set; }

}

