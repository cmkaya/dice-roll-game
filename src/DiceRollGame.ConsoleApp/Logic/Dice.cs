namespace DiceRollGame.ConsoleApp.Logic;

public class Dice
{
  public int NumberOfSides { get; } = 6;
  private readonly Random _random = Random.Shared;

  public int Roll() => _random.Next(1, NumberOfSides + 1);
}