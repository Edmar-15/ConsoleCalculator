# ConsoleCalculator

A lightweight, extensible .NET 8 console calculator providing arithmetic and scientific calculations, unit conversions, session history, and a small interactive mini‑game. Designed as a clean starter for CLI apps and quick demos.

Badges
- Targets: .NET 8

Quick summary
- Small, focused, and easy to extend
- Clear separation of concerns: `BasicOperations`, `ScientificCalculation`, `UnitConversion`, `HistoryManager`, and `MiniGame`
- Single entrypoint: `Program.cs`

Prerequisites
- .NET 8 SDK (install from https://dotnet.microsoft.com)
- Visual Studio 2022 (optional) or any editor/terminal

Getting started (CLI)
1. Clone: git clone https://github.com/Edmar-15/ConsoleCalculator.git cd ConsoleCalculator

2. Build: dotnet build

3. Run: dotnet run --project ConsoleCalculator


Getting started (Visual Studio)
- Open the solution in Visual Studio 2022.
- Ensure the project targets `.NET 8` via __Project Properties > Target Framework__ if needed.
- Build the solution with __Build__ and run with __Debug > Start Debugging__ or press __F5__.

Usage examples
- Expression mode (type arithmetic expressions):  
Example: `2 + 3 * (4 - 1)`
- Basic operations: `add 2 3` (or enter via interactive prompt — see `Program.cs` for exact commands)
- Unit conversion (example): `convert 100 cm m`
- View session history: `history` or `hist`
- Start mini-game: `play`

Note: Exact console commands and syntax are implemented in `Program.cs`. Open it to see the interactive command loop and available commands.

Project layout
- `Program.cs` — CLI entry and command dispatch
- `Classes/BasicOperations.cs` — basic arithmetic helpers
- `Classes/ScientificCalculation.cs` — trig, powers, logs, etc.
- `Classes/UnitConversion.cs` — length, mass, temperature converters
- `Classes/HistoryManager.cs` — session history persistence
- `Classes/MiniGame.cs` — interactive mini-game mode

Extending the project
- Add new operation or converter by adding a class to `Classes/` and registering it in `Program.cs`.
- Keep methods small and focused; add unit tests where appropriate.

Contributing
1. Fork the repository.
2. Create a topic branch: `git checkout -b feature/your-feature`
3. Implement your changes and add tests.
4. Open a pull request describing your changes.

Support& notes
- This project targets .NET 8. If you need to changethe target, update the project's Target Framework in __Project Properties > Target Framework__ or edit the `.csproj` TFM.
- For detailed behaviorof commands, consult `Program.cs` and the classes in `Classes/`.

If you’d like, I can generate a badge set, CI workflow, or a more detailed command reference extracted directly from `Program.cs`.
