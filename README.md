# Create API Client

[![Unit and Integration Tests](https://github.com/TheLe0/create-api-client/actions/workflows/tests.yml/badge.svg)](https://github.com/TheLe0/create-api-client/actions/workflows/tests.yml)

## Introduction

This a template for quickly creating client libraries for consuming APIs in .NET. The template is already a complete solution, you can quickly personalizate it to your own APIs.

This templete contains:

* Unit and integration tests;
* An isolated DI package;
* Samples on how to use (WebAPI and Console);
* Workflows (CI and CD).

The goal of the template is to simplify the process of creating client libraries for APIs in .NET, allowing you to focus on business logic rather than worrying about implementing API calls.

The repository includes detailed documentation on how to use the template, as well as examples of usage. It also includes a guide on how to contribute to the project and report issues.

If you need to create a client library for consuming an API in .NET, the .NET template for API clients can be a good option to save time and effort.

The solution was designed with the best softwares approaches to avoid code coupling and easy to adapt and add new stuff to it.

## Configuration

After you created your repository based on this template, you have just a few steps to do for your package be avaliable on NuGet.

1. On the Github repository secrets add a new secret called ```NUGET_API_KEY``` and the value you must generate a key on NuGet, [here](https://www.nuget.org/account/apikeys);

2. On the ```csproj``` files (both the main project and the DI) and change the following parameters with your own data:

```csharp
    <Version>1.0.0</Version>
    <Authors>Leonardo Tosin</Authors>
    <PackageProjectUrl>https://github.com/TheLe0/create-api-client</PackageProjectUrl>
    <PackageIconUrl>https://github.com/TheLe0/bacen-dollar-api-client/assets/40045069/b14e8770-75d7-40d1-adc7-4a8dde1885c9</PackageIconUrl>
    <PackageIcon>images\logo.png</PackageIcon>
    <PackageTags>API client</PackageTags>
   <Description>Replace this for your package description</Description>
   <Copyright>Copyright © Leonardo Tosin</Copyright>
   <AssemblyVersion>1.0.0</AssemblyVersion>
   <FileVersion>1.0.0</FileVersion>
    <PackageVersion>1.0.0</PackageVersion>
```

Where:

* <b>Version, AssemblyVersion, FileVersion and PackageVersion</b>: The version of your package to be released. Is a good approach all versions be the same;
* <b>Authors</b>: The main authors and contributors to the project;
* <b>PackageProjectUrl</b>: The repository of your project;
* <b>PackageIconUrl</b>: The url of the package logo;
* <b>PackageIcon</b>: The logo of your package (you must changed the logo.png on the project root with your own logo);
* <b>Copyright</b>: The signature of your package;
* <b>PackageTags</b>: The key words of your package, for searching on NuGet;
* <b>Description</b>: The small description of your project.

3. Refactor all classes and objects names called ```Create.API.Client```, ```CreateApiClient``` to your project preference and business logic.

And now you are ready to go!
