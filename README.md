# Introduction

Visual Studio project templates are a great way to quickly create consistent projects. This template follows the same project structure outlined in the [general documentation](https://dev.azure.com/rmits/_git/Documentation?path=/ReadmeSections/Project-Structure-Info.md&version=GBmain&_a=preview). This solution is intended to be used to install the MAUI and Blazor Web Combined Template project type.

# Setup
This project was setup following [Microsoft Documentation](https://docs.microsoft.com/en-us/visualstudio/ide/creating-project-and-item-templates?view=vs-2022) on creating project templates. It includes the following projects:

- **.NET Maui Blazor App (Preview)**: `MauiBlazorWebTemplate` project
- **Razor Class Library**: `MauiBlazorWebTemplate.Ui` project
- **Class Library**: `MauiBlazorWebTemplate.Shared` project
- **Blazor WebAssembly App**: `MauiBlazorWebTemplate.Wasm` project
- **Blazor Server App**: `MauiBlazorWebTemplate.ServerOnly` project

The template is setup to be able to create a new solution that contains all of the Blazor Web projects, the MAUI project, and a Shared Class and Component library. The Component Library has all of the routable pages and shared components used as the UI for all of the other project types. The Shared Class library contains all of the shared models and interfaces.

# Getting Started
As mentioned, this solution is intended to be installable as a Template to use to quickly build up an application that uses a combination of MAUI--for targetting Windows, Android, iOS, macOS, and Tizen--with a Blazor Component Library for the UI and the WASM and Server project types for Web.

Use the DotNET CLI to install the template. First, navigate to the solution folder in a command prompt. Then type:

```ps
dotnet new -i .
```

You can also just replace the `.` at the end of the command with the path to the folder that has the MauiBlazorWebTemplate solution file. You could also install the template from any directory by providing the full path in place of `.`. 

To use the template to create a new project, type:

```ps
dotnet new maui-blazor-web
```

The template is also installed to be useable in Visual Studio using File -> New Project.

## Upcoming/TODO
- Turn this into a NuGet package to be pushed to NuGet.org
- Add options (CLI switches and File -> New Project checkboxes) to choose which combination of projects to include
- Add an ASP.NET Hosted API project that can be optionally added when creating a new project
- Update to GA version of MAUI when it is released
