using DiceRollGame.ConsoleApp.UserCommunication;

namespace DiceRollGame.ConsoleApp.Logic;

public class GuessingGame
{
  private readonly Dice _dice;
  private const int MaxAttemptLimit = 3;

  public GuessingGame(Dice dice)
  {
    _dice = dice;
  }
  
  public GameResult Play()
  {
    var currentAttempt = 0;
    var diceRollResult = _dice.Roll();

    Console.WriteLine("Dice is rolling... Guess the number between 1 and {0}. You have {1} attempts.", 
      arg0: _dice.NumberOfSides,
      arg1: MaxAttemptLimit);
    
    do
    {
      var guess = ConsoleReader.ReadIntegers("Enter your guess: ");
      if (diceRollResult == guess)
      {
        return GameResult.Win;
      }
      Console.WriteLine("Wrong guess. Try again.");

      ++currentAttempt;
    } while (currentAttempt < MaxAttemptLimit);

    return GameResult.Lose;
  }

  public static void PrintResult(GameResult result)
  {
    var message = result == GameResult.Win ? "You won!" : "You lost!";
    Console.WriteLine(message);
  }
}