🎮 Treasure Hunt Adventure
A console-based treasure hunting game written in C#. Navigate through a grid-based map, collect treasures while avoiding deadly traps, and compete for the top spot on the leaderboard!
📋 Table of Contents

Features
Requirements
Installation
How to Play
Game Mechanics
Configuration
Leaderboard System
Controls
Tips & Strategies

✨ Features

Dynamic Grid-Based Gameplay - Navigate through customizable map sizes
Persistent Leaderboard - Top 10 scores saved with player names and completion times
Game Statistics - Track your wins, losses, and win rate
Customizable Difficulty - Adjust map size, treasure count, and trap count
Color-Coded UI - Easy-to-read visual elements with ASCII art borders
Timer System - Race against the clock to improve your completion time
Safe Spawn System - Never start on a trap or treasure

💻 Requirements

.NET Framework 4.5+ or .NET Core 3.1+ or .NET 5.0+
Windows, macOS, or Linux with console support
Terminal with Unicode support (for box-drawing characters)

🚀 Installation
Method 1: Compile from Source

Clone or download this repository
Open a terminal in the project directory
Compile the game:

bash   csc Program.cs
Or if using .NET CLI:
bash   dotnet build

Run the executable:

bash   TreasureHunt.exe
Or:
bash   dotnet run
Method 2: Using Visual Studio

Open the .cs file in Visual Studio
Press F5 to build and run
Alternatively, build the solution and run the generated executable

🎯 How to Play
Objective
Collect all treasures ($) on the map while avoiding traps (X). Complete the game as quickly as possible to earn a spot on the leaderboard!
Starting a Game

Launch the game
Select [1] Start New Game from the main menu
Use arrow keys to navigate the map
Collect all treasures to win
Hit a trap and it's game over!

🎲 Game Mechanics
Symbols
SymbolColorDescription@YellowYour character$GreenTreasure (collect all to win)XRedTrap (instant game over).WhiteEmpty space
Victory Condition
Collect all treasures on the map without hitting any traps.
Defeat Condition
Step on a trap (X) before collecting all treasures.
Scoring

Score = Number of treasures collected
Time = How long it took to complete the game
Leaderboard ranks by score first, then by fastest completion time

⚙️ Configuration
Access the configuration menu via [2] Game Configuration:
SettingDefaultRangeDescriptionMap Width205-30Horizontal size of the game boardMap Height105-20Vertical size of the game boardTreasures51-50% of mapNumber of treasures to collectTraps51-50% of mapNumber of traps to avoid
Note: The game prevents setting treasure/trap counts that exceed 50% of available map spaces.
🏆 Leaderboard System
How It Works

Only victories (collecting all treasures) qualify for the leaderboard
Top 10 scores are saved permanently
Sorted by:

Score (treasures collected) - Highest first
Time (completion time) - Fastest first



Leaderboard File

Stored in leaderboard.txt in the game directory
Format: Name|Score|Date|Time
Automatically loads on game start
Automatically saves after qualifying games

Viewing the Leaderboard
Select [5] View Leaderboard from the main menu to see:

Rank (1-10)
Player name (up to 15 characters)
Score achieved
Completion time (MM:SS format)
Date achieved

🎮 Controls
KeyAction↑ (Up Arrow)Move up↓ (Down Arrow)Move down← (Left Arrow)Move left→ (Right Arrow)Move rightESCReturn to main menu / Exit configuration1-6Menu selection
💡 Tips & Strategies

Plan Your Route - Look at the entire map before moving
Stay Patient - Rushing leads to trap collisions
Corner First - Collect treasures in corners first to avoid getting trapped
Watch Your Path - Remember where traps are located
Time Management - Balance speed with safety for better leaderboard rankings
Custom Difficulty - Start with fewer traps to practice, then increase difficulty
Safe Spawn - You'll never start on a trap or treasure, so plan from a safe position

📊 Statistics
Track your performance via [4] View Statistics:

Games Played - Total number of games started
Games Won - Victories (all treasures collected)
Games Lost - Defeats (hit a trap)
Win Rate - Percentage of games won
Best Score - Highest treasure count achieved

🐛 Troubleshooting
Box Characters Not Displaying
If you see strange characters instead of boxes:

Ensure your console supports Unicode
On Windows: Use Windows Terminal instead of CMD
Set console encoding: Console.OutputEncoding = System.Text.Encoding.UTF8;

Leaderboard Not Saving

Ensure the game has write permissions in its directory
Check if leaderboard.txt exists and is not read-only
The file will be created automatically on the first qualifying score

Game Too Easy/Hard

Adjust settings in the Configuration menu
Try: 30x20 map with 10 treasures and 15 traps for extreme difficulty
Or: 10x5 map with 3 treasures and 2 traps for easy mode

📝 License
This project is provided as-is for educational and entertainment purposes.
🤝 Contributing
Feel free to fork, modify, and enhance this game! Some ideas for improvements:

Power-ups (shields, trap detectors)
Different trap types (teleporters, fake treasures)
Fog of war (limited visibility)
Multiplayer mode
Sound effects
Different difficulty presets
Achievement system

![Demo Screenshot](playing.png)

![Demo Screenshot](gameres.png)

![Demo Screenshot](learderboard.png)

