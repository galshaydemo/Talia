# Talia .NET Framework 4.8 Console App

This repo includes a minimal C# console application targeting **.NET Framework 4.8**. Note that .NET Framework 4.8 builds and runs only on Windows.

## Structure
- `Talia48.Console/Talia48.Console.csproj`: SDK-style project targeting `net48`.
- `Talia48.Console/Program.cs`: Hello World entry point.
- `index.html`: Existing static file (unrelated to the .NET project).

## Prerequisites (Windows)
- Visual Studio 2022 with **.NET desktop development** workload, or
- .NET Framework 4.8 Developer Pack + latest .NET SDK.

## Build (Windows)
```powershell
# Using dotnet SDK
dotnet build Talia48.Console/Talia48.Console.csproj -c Debug

# Using MSBuild (from Developer Command Prompt)
MSBuild Talia48.Console/Talia48.Console.csproj /p:Configuration=Debug
```

## Run (Windows)
After build, run the generated executable:
```powershell
./Talia48.Console/bin/Debug/net48/Talia48.Console.exe
```

## Notes
- On macOS/Linux, building `net48` is not supported. If you need cross-platform dev locally, consider adding a parallel project targeting `net8.0` and sharing code via multi-targeting.
- To multi-target, you can change the project to:
```xml
<PropertyGroup>
  <TargetFrameworks>net48;net8.0</TargetFrameworks>
</PropertyGroup>
```
…but the `net48` target will still require Windows.
