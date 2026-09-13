
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
People_Collection response = client.People().getAll("search");

// Get a specific people.
People response = client.People().get("id");

// Get all the films.
Film_Collection response = client.Film().getAll("search");

// Get a specific film.
Film response = client.Film().get("id");

// Get all the starships.
Starship_Collection response = client.Starship().getAll("search");

// Get a specific starship.
Starship response = client.Starship().get("id");

// Get all the species.
Species_Collection response = client.Species().getAll("search");

// Get a specific species.
Species response = client.Species().get("id");

// Get all the vehicles.
Vehicle_Collection response = client.Vehicle().getAll("search");

// Get a specific vehicle.
Vehicle response = client.Vehicle().get("id");

// Get all the planets.
Planet_Collection response = client.Planet().getAll("search");

// Get a specific planet.
Planet response = client.Planet().get("id");
```
