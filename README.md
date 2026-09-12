# ValheimMod

A client-side Valheim mod built with BepInEx 5.

## Installation

Install BepInExPack_Valheim 5.4.2350 in your mod profile. Copy `ValheimMod.dll`
from a release ZIP into `BepInEx/plugins/ValheimMod/`, then start the game modded.

## Build

```sh
dotnet build src/ValheimMod/ValheimMod.csproj -c Release -t:Package \
  -p:GameDir="/path/to/Valheim" \
  -p:BepInExDir="/path/to/profile/BepInEx"
```

Requires .NET SDK 8 and Python 3.10+. Output: `artifacts/ValheimMod-1.0.0.zip`.

[Development and releases](docs/DEVELOPMENT.md) · [Repository layout](docs/REPOSITORY.md) · [Using the template](docs/TEMPLATE.md)
