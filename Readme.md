# BlipBinding

**_BlipBinding_** is an ASP.NET MVC case study solution created to accompany a guide in the [**PluralSight Guides**](https://www.pluralsight.com/guides) collection for Microsoft .NET technologies.

## PluralSight Guides

[ASP.NET MVC - Getting default data binding right for hierarchical views](https://app.pluralsight.com/guides/asp.net-mvc-getting-default-data-binding-right-for-hierarchical-views) - The power of default model binding in ASP.NET MVC extends beyond the flat data model of a simple input form or list of records. Using a few straightforward coding techniques, developers can use ASP.NET to create forms and collect data for hierarchical entity relationships. This guide presents an example of using ASP.NET MVC model binding to present and collect hierarchical form data in a hierarchical structure.

*Notice: PluralSight and the author(s) disclaim any liability for errors or omissions in this code. See the [Disclaimer of Warranties and Limitation of Liability](#disclaimer-of-warranties-and-limitation-of-liability) for complete information.*

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

## License

This project is licensed under the terms of the MIT license.

## Contributing

See the accompanying instructions on [How to contribute](CONTRIBUTING.md).

## Disclaimer of Warranties and Limitation of Liability

The contents of this repository are offered on an as-is and as-available basis and the authors make no representations or warranties of any kind concerning the contents, whether express, implied, statutory, or other. This includes, without limitation, warranties of title, merchantability, fitness for a particular purpose, non-infringement, absence of latent or other defects, accuracy, or the presence or absence of errors, whether or not known or discoverable.

To the extent possible, in no event will the authors be liable on any legal theory (including, without limitation, negligence) or otherwise for any direct, special, indirect, incidental, consequential, punitive, exemplary, or other losses, costs, expenses, or damages arising out of the use of the contents, even if the the authors have been advised of the possibility of such losses, costs, expenses, or damages.

The disclaimer of warranties and limitation of liability provided above shall be interpreted in a manner that, to the extent possible, most closely approximates an absolute disclaimer and waiver of all liability.
