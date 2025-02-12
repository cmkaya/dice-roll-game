# Dice Roll Game

A C# console application that implements a simple dice guessing game. This project demonstrates fundamental programming concepts through a straightforward game implementation.

## Project Overview

The game is organized into focused components that handle different aspects of the gameplay:

- `Dice.cs`: Manages dice rolling and random number generation
- `GuessingGame.cs`: Controls the main game flow
- `ConsoleReader.cs`: Handles user input with validation
- `GameResult.cs`: Defines possible game outcomes

## Gameplay

The game provides a straightforward interactive experience. Here's what you'll see when playing:

```
Dice is rolling... Guess the number between 1 and 6. You have 3 attempts.
Enter your guess: 3
Wrong guess. Try again.
Enter your guess: 5
You won!
```

Key features:
- Guess a number between 1 and 6
- Up to three attempts per game
- Input validation ensures only valid numbers are accepted
- Clear feedback after each guess

## Getting Started

### Prerequisites

- .NET SDK (8.0 or later)
- Git (optional, for cloning the repository)

### Running the Application

1. Clone and navigate to the project:
```bash
git clone https://github.com/your-username/dice-roll-game.git
cd dice-roll-game
```

2. Build the solution:
```bash
dotnet build
```

3. Start the application:
```bash
dotnet run --project src/DiceRollGame.ConsoleApp
```

## Learning Points

This project demonstrates several basic programming concepts:

- Using classes to organize related functionality
- Basic random number generation
- Console input handling and validation
- Game state management using enums
- Simple control flow with loops and conditions