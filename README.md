# Bacon Ipsum .NET API Client

[![Unit and Integration Tests](https://github.com/TheLe0/bacon-ipsum-api-client/actions/workflows/tests.yml/badge.svg)](https://github.com/TheLe0/bacon-ipsum-api-client/actions/workflows/tests.yml)

![bacon-ipsum-banner1](https://github.com/TheLe0/create-api-client/assets/40045069/46189b98-39ab-414b-9f6c-8893ffc7ff03)

## Introduction

This is a .NET package for random text generation. Good for testing the responsivity of front-end applications to see the behaviour of the layouts, if it grows and decreases in the ideal proportion.

## Packages

   | Package | Version | Downloads | Workflow |
   |---------|---------|-----------|----------|
   | [Bacon.Ipsum.API.Client](https://www.nuget.org/packages/Bacon.Ipsum.API.Client/) | [![NuGet Version](https://img.shields.io/nuget/v/Bacon.Ipsum.API.Client.svg)](https://www.nuget.org/packages/Bacon.Ipsum.API.Client/ "NuGet Version")| [![NuGet Downloads](https://img.shields.io/nuget/dt/Bacon.Ipsum.API.Client.svg)](https://www.nuget.org/packages/Bacon.Ipsum.API.Client/ "NuGet Downloads") | [![Deploy](https://github.com/TheLe0/bacon-ipsum-api-client/actions/workflows/deploy_nuget_api_client.yml/badge.svg)](https://github.com/TheLe0/bacon-ipsum-api-client/actions/workflows/deploy_nuget_api_client.yml) |
   | [Bacon.Ipsum.API.Client.DependencyInjection](https://www.nuget.org/packages/Bacon.Ipsum.API.Client.DependencyInjection/) | ![NuGet Version](https://img.shields.io/nuget/v/Bacon.Ipsum.API.Client.DependencyInjection.svg) | [![NuGet Downloads](https://img.shields.io/nuget/dt/Bacon.Ipsum.API.Client.DependencyInjection.svg)](https://www.nuget.org/packages/Bacon.Ipsum.API.Client.DependencyInjection "NuGet Downloads") | [![Deploy](https://github.com/TheLe0/bacon-ipsum-api-client/actions/workflows/deploy_nuget_api_client_di.yml/badge.svg)](https://github.com/TheLe0/bacon-ipsum-api-client/actions/workflows/deploy_nuget_api_client_di.yml) |

## Endpoints

1. [GenerateSentenceAsync](https://baconipsum.com/api/?type=all-meat&sentences=1&start-with-lorem=1): Generate a text with a specific amount of sentences;

```csharp
var response = await client.TextGenerator
    .GenerateSentenceAsync(1)
    .ConfigureAwait(false);
);
```

1. [GenerateParagraphAsync](https://baconipsum.com/api/?type=all-meat&paras=2&start-with-lorem=1): Generate a text with a specific amount of paragraphs;

```csharp
var response = await client.TextGenerator
    .GenerateParagraphAsync(1)
    .ConfigureAwait(false);
);
```

## Configuration

This Api integration is ver simple, there is no authentication/authorization requirements, you can use it with almost no configurations.

You can instanciate this client in three different ways:

1. Using default configs (This uses the values inside the Configurations resource file):

```csharp
var client = new BaconIpsumApiClient();
```

or by dependency injection:

```csharp
services.AddBaconIpsumApiClient();
```

2. Only configurating the API base url:

```csharp
var client = new BaconIpsumApiClient(baseUrl);
```

or by dependency injection:

```csharp
services.AddBaconIpsumApiClient(baseUrl);
```

3. And setup manually all configurations with your preferences:

```csharp
var configs = new BaconIpsumApiClientConfiguration
{
    BaseUrl = baseUrl,
    MaxTimeout = maxTimeOut,
    ThrowOnAnyError = throwOnErrors,
    StartWithLorem = true,
    Type = TextContentType.MEAT_AND_FILLER
};

var client = new BaconIpsumApiClient(configs);
```

or by dependency injection:

```csharp
var configs = new BaconIpsumApiClientConfiguration
{
    BaseUrl = baseUrl,
    MaxTimeout = maxTimeOut,
    ThrowOnAnyError = throwOnErrors,
    StartWithLorem = true,
    Type = TextContentType.MEAT_AND_FILLER
};

services.AddBaconIpsumApiClient(configs);
```
