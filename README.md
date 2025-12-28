# ConsoleCalculator

A lightweight, extensible console calculator targeting .NET 8. Provides basic arithmetic, scientific functions, unit conversions, session history, and a small interactive mini‑game. Designed as a clean starter project for CLI apps and quick demos.

Badges
- Targets: `.NET 8`

Overview
- Clean, focused codebase with clear separation of concerns.
- Single entrypoint: `Program.cs`.
- Core pieces implemented as static helpers under `Classes/` for easy extension.

Features
- Basic arithmetic: addition, subtraction, multiplication, division, remainder (`Classes/BasicOperations.cs`).
- Scientific functions: trigonometry, powers, logs (see `Classes/ScientificCalculation.cs`).
- Unit conversions (see `Classes/UnitConversion.cs`).
- Session history persisted in-memory for the running session (`Classes/HistoryManager.cs`).
- A small interactive mini-game (`Classes/MiniGame.cs`).

Prerequisites
- .NET 8 SDK — download from https://dotnet.microsoft.com
- Visual Studio 2022 (optional) or any code editor/terminal

Quick start (CLI)
1. Clone the repository:
   git clone https://github.com/Edmar-15/ConsoleCalculator.git
   cd ConsoleCalculator
2. Build:
   dotnet build
3. Run:
   dotnet run --project ConsoleCalculator

Quick start (Visual Studio)
- Open the solution in Visual Studio 2022.
- Confirm the project targets `.NET 8` via __Project Properties > Target Framework__.
- Build with __Build__ and run with __Debug > Start Debugging__ (F5).

Usage
- Run the application to open the main interactive menu implemented in `Program.cs`.
- Select the desired mode from the main menu:
  - Basic operations: interactive submenu with options for `Addition`, `Subtraction`, `Multiplication`, `Division`, `Remainder`, and returning to the main menu. (See `Classes/BasicOperations.cs`.)
  - Scientific calculations: access scientific helpers from `Classes/ScientificCalculation.cs`.
  - Unit conversions: convert between supported units in `Classes/UnitConversion.cs`.
  - View session history recorded by `Classes/HistoryManager.cs`.
  - Play the built-in mini-game in `Classes/MiniGame.cs`.
- Example (Basic operations): choose the Basic Operations menu, then select `1` for Addition, enter two numbers — the result is displayed and saved to session history.

Notes & known issues
- Division behavior follows the original implementation; there is no explicit divide-by-zero guard in `Classes/BasicOperations.cs`. Consider adding validation to prevent exceptions.
- History is session-scoped (in-memory). Persisting history to disk can be added if needed.

Extending the project
- Add new features by creating classes under `Classes/` and invoking them from `Program.cs`.
- Keep new methods small and well-documented; add unit tests where appropriate.

Contributing
1. Fork the repository.
2. Create a branch: `git checkout -b feature/your-feature`
3. Implement changes and add tests.
4. Open a pull request with a clear description of changes.

License
- See `LICENSE.md` in the repository.

Support & tips
- To change the target framework edit the project TFM or use __Project Properties > Target Framework__.
- For command and menu details consult `Program.cs` and the class files under `Classes/`.

Repository
- Remote origin: https://github.com/Edmar-15/ConsoleCalculator
