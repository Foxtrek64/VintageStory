# CoreLib

`LuzFaltex.VintageStory.CoreLib`

This plugin and framework creates a non-opinionated, low-level API for systems missing from the core game. It is designed to be provider-agnostic, allowing mods which rely on specific functionality to remain unconcerned with what is providing that functionality and how that functionality is provided.

## Providers

`IEconomyProvider` - Request this provider from the server to access economy functions, such as creating and destroying bank accounts, adding, removing, or transferring money, and checking account balance.

## Creating a provider

If you are a provider, you can include this library from NuGet and create a type that implements the appropriate provider. For instance, a plugin which provides an economy system should create a type which implements `IEconomyProvider`.

Once created, this provider needs to be registered with the server. To do so, review the following code sample:

```cs
