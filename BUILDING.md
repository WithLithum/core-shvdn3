# Building Guides

Building difficulities depends on your platform and your tools.

## Setting up the environment

Download and install these tools if you haven't already:

* Visual Studio 2022 (or build tools), with .NET Desktop Development workload
* If you use build tools, NuGet CLI in your `PATH`.

## Building the project

Select the way to prefer.

### Building via IDE

* Open the project in Visual Studio.
* Click Build -> Build Solution.
* Binaries should be ready in the `bin` folder.

### Building via the Command Line

* Open Visual Studio Developer PowerShell.
* Navigate to the project folder.
* Run `nuget restore`.
* Run `msbuild`.
* Binaries should be ready in the `bin` folder.