# Rikuta

> 👷 The project is currently under heavy development. Primarily *Rikuta.Models* project is being implemented.

Rikuta is a library for dealing with Discord API endpoints. The project consists of these subprojects:

- *Rikuta* - Meta-project that links to other ones.
- *Rikuta.Models* - contains definitions for most entities used across endpoints. You can use this project by itself, manually dealing with Discord.
- *Rikuta.Rest* - Contains functionality to deal with Discord's REST API.
- *Rikuta.Gateway* - Contains functionality to deal with Discord's Gateway API.
- *Rikuta.Common* - [Planned for future] Will contain functionality for common tasks, You probably be dealing with Discord as different types of command handling and so on.

## Rikuta.Models

This subproject relies on *System.Text.Json* JSON serialization implementation where each field of entities is annotated with attributes, defined in the *JsonAttributes.cs* file. In case you want to use this on its own, with your serializer, you can copy this project locally and change the appropriate attributes. But beware that other components of Rikuta assume System.Text.Json is being used so that can cause trouble.
