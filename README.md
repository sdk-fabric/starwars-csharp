
# starwars-csharp

This [SDK](https://github.com/sdk-fabric/starwars-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/sdkfabric/starwars

## Usage

```csharp
using SdkFabric.Starwars.Client;

Client client = Client.Build("[access_token]")

// Get all the people.
PeopleCollection response = client.People().Getall("search");

// Get a specific people.
People response = client.People().Get("id");

// Get all the films.
FilmCollection response = client.Film().Getall("search");

// Get a specific film.
Film response = client.Film().Get("id");

// Get all the starships.
StarshipCollection response = client.Starship().Getall("search");

// Get a specific starship.
Starship response = client.Starship().Get("id");

// Get all the species.
SpeciesCollection response = client.Species().Getall("search");

// Get a specific species.
Species response = client.Species().Get("id");

// Get all the vehicles.
VehicleCollection response = client.Vehicle().Getall("search");

// Get a specific vehicle.
Vehicle response = client.Vehicle().Get("id");

// Get all the planets.
PlanetCollection response = client.Planet().Getall("search");

// Get a specific planet.
Planet response = client.Planet().Get("id");
```
