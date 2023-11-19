# RavenRock RP Vintage Story Mods

This repostitory contains all of the official, custom mods used in the RavenRock RP Community. These mods are open source and provided for reference under the LGPL license.

## Libraries

### [RavenChat](./src/LuzFaltex.VintageStory.ChatChannels/README.md)
`LuzFaltex.VintageStory.ChatChannels`

This library replaces the in-game chat system to allow for multiple channels (both ranged and global), alternative chat views, advanced permissioning, chat moderation, and command hints and tab completion.

### [Commander](./src/LuzFaltex.VintageStory.Commands/README.md)
`LuzFaltex.VintageStory.Commands`

This library extends the default command system. Powered by [Remora.Commands](https://github.com/Remora/Remora.Commands), this library strives to provide a more powerful command system with code generation as well as powering the command hints and tab completion available to RavenChat.

### [CoreLib](./src/LuzFaltex.VintageStory.CoreLib/README.md)
`LuzFaltex.VintageStory.CoreLib`

Inspired by the [Vault](https://www.spigotmc.org/resources/vault.34315/) plugin from Bukkit/Spigot Minecraft Servers, this plugin provides some base API functionality for bridging mods in a way that requires zero knowlege of the consumer or the provider.

The system works like passing notes in class. The consumer writes a note that says "I want $5 from this user." CoreLib passes that note to the economy mod, who then takes the money from the user and passes it back to CoreLib. CoreLib then passes it back to the consumer.

Current APIs (feel free to suggest more):

- Economy API - connect your mod with a generic economy API to allow for purchases or exchange of currency.

### [Extensions](./src/LuzFaltex.VintageStory.Extensions/README.md)
`LuzFaltex.VintageStory.Extensions`

A basic extension library. Just provides some helpers to make life easier when consuming the Vintage Story API.

### [Guilded Empire](./src/LuzFaltex.VintageStory.Guilds/README.md)
`LuzFaltex.VintageStory.Guilds`

Provides the ability to create Guilds or Factions, as well as parties. Guilds are highly customizable, formalized groups with an owner and the ability to claim land as complete chunks (32^3^ areas).

Parties are designed to give groups of players advantages in adventuring. It is intended for RPG servers. Party members are able to share information such as health and hunger, access a shared inventory where healing supplies and other resources can be held, and when used with RavenChat, will have a private channel just for their party.

The `LuzFaltex.VintageStory.Guilds.Abstractions` library is provided for mod developers who wish to integrate with factions to provide extended features. It contains all of the interfaces used to describe parties, guilds, and other aspects of the system.

### [Mod Configuration Menu](./src/LuzFaltex.VintageStory/ModConfigurationMenu/README.md)
`LuzFaltex.VintageStory.ModConfigurationMenu`

This mod provides a unified options screen for the in-game configuration of mods. The mod listing can be organized into categories. Each mod gets its own page, where mods can register a set of options using a system that feels very much like the command API. Sections can be added as well, to help further divide commands. Visibility options can also be configured, so options that a player does not have rights to configure can either be disabled (read-only) or hidden entirely.

### [PlaceholderAPI](./src/LuzFaltex.VintageStory.PlaceholderAPI/README.md)
`LuzFaltex.VintageStory.PlaceholderAPI`

Inspired by the [PlaceholderAPI](https://www.spigotmc.org/resources/placeholderapi.6245/) plugin for Bukkit/Spigot, this mod provides the ability to use placeholders in formatting strings. Mods can register placeholder strings and an `IReplacementHandler` for that placeholder string. Mods like RavenChat can then request PlaceholderAPI to perform the replacement, searching for the requested replacement handler based off the placeholder string and then executing that replacement handler to retrieve the result.

There are several built-in handlers. Please review the documentation for this mod for more details.