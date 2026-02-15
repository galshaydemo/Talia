# Talia .NET Framework 4.8 Console App

This repo includes a minimal C# console application targeting **.NET Framework 4.8** and **.NET 8.0** via multi-targeting.
Note: `.NET Framework 4.8 (net48)` builds/runs only on Windows; `net8.0` is cross-platform.

## Structure
- `Talia48.Console/Talia48.Console.csproj`: SDK-style project targeting `net48;net8.0`.
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

## macOS/Linux
- Build only the `net8.0` target:
```bash
dotnet build Talia48.Console/Talia48.Console.csproj -c Debug -f net8.0
dotnet run --project Talia48.Console/Talia48.Console.csproj -f net8.0 -- hello world
```

- `net48` cannot be built/run on macOS/Linux; use Windows for that target.

## CI: Build net48 on GitHub Actions
- A workflow at [.github/workflows/build-net48.yml](.github/workflows/build-net48.yml) builds the `net48` target on `windows-latest` and uploads artifacts.
- Trigger: on push to `main` or manual via “Run workflow”.
- Artifact location: download from the workflow run (look for `Talia48-Console-net48`).

### Requirements handled by the project
- The project includes a conditional reference to `Microsoft.NETFramework.ReferenceAssemblies` to ensure `net48` compilation in CI.
