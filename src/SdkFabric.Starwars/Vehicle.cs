/**
 * Vehicle automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Starwars;

/// <summary>
/// A Vehicle resource is a single transport craft that does not have hyperdrive capability.
/// </summary>
public class Vehicle
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("model")]
    public string? Model { get; set; }
    [JsonPropertyName("vehicle_class")]
    public string? VehicleClass { get; set; }
    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }
    [JsonPropertyName("length")]
    public string? Length { get; set; }
    [JsonPropertyName("cost_in_credits")]
    public string? CostInCredits { get; set; }
    [JsonPropertyName("crew")]
    public string? Crew { get; set; }
    [JsonPropertyName("passengers")]
    public string? Passengers { get; set; }
    [JsonPropertyName("max_atmosphering_speed")]
    public string? MaxAtmospheringSpeed { get; set; }
    [JsonPropertyName("cargo_capacity")]
    public string? CargoCapacity { get; set; }
    [JsonPropertyName("consumables")]
    public string? Consumables { get; set; }
    [JsonPropertyName("films")]
    public List<string>? Films { get; set; }
    [JsonPropertyName("pilots")]
    public List<string>? Pilots { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }
    [JsonPropertyName("edited")]
    public DateTime? Edited { get; set; }
}