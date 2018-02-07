# BlipBinding

**_BlipBinding_** is an ASP.NET MVC case study solution created to accompany a guide in the **PluralSight** [**HackGuides()**](https://www.pluralsight.com/guides/microsoft-net) collection for Microsoft .NET technologies.

## PluralSight Hack.Guides()

[ASP.NET MVC - Getting default data binding right for hierarchical views](https://www.pluralsight.com/guides/microsoft-net/asp-net-mvc-getting-default-data-binding-right-for-hierarchical-views) - The power of default model binding in ASP.NET MVC extends beyond the flat data model of a simple input form or list of records. Using a few straightforward coding techniques, developers can use ASP.NET to create forms and collect data for hierarchical entity relationships. This guide presents an example of using ASP.NET MVC model binding to present and collect hierarchical form data in a hierarchical structure.

*Notice: PluralSight and the author disclaim any liability for errors or omissions in this code.*

## Design Patterns

Model-View-ViewModel
Repository

## Solution Projects

| Project | Application Layer |
| :--- | :--- |
| Blip.Data | Data Context and Repositories |
| Blip.Entities | Data Entities |
| Blip.Web | User Interface (views) and Business Logic (controllers) |

## Technologies

| Dependency | Version*
| :--- | ---:
| .NET Framework | 4.6.2
| ASP.NET MVC | 5.2.3
| Bootstrap | 3.3.7
| C# | 6
| Entity Framework | 6.1.3
| jQuery | 3.2.1
| jQuery Validation | 1.16.0
| Microsoft Identity | 2.2.1
| Microsoft jQuery Unobtrusive Validation | 3.2.3

&ast; As of the latest commit.

## Getting Started

1. Download or clone this repository.
1. Open the solution in Visual Studio 2017 or higher.
1. Select the **Blip.Data** project.
1. Open a Package Manager Console window.
1. Select "Blip.Data" for **Default Project**.
1. Run: `update-database`. 

This will create the database, apply Entity Framework migrations, and run the `Seed` method to populate the database with values for the lookup tables.

## Configuration

* Two projects contain configuration strings which may require modification for the developer's specific environment:

    | Project | File
    | :--- | :---
    | Blip.Data | App.config
    | Blip.Web | Web.config

* The configuration strings specify the instance of SQL Server Express installed with Visual Studio 2017 as the target database server: `Data Source=(localdb)\ProjectsV13`. Developers using a different target database will have to change the connection strings in both projects.