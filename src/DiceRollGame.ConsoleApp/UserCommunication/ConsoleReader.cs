namespace DiceRollGame.ConsoleApp.UserCommunication;

public static class ConsoleReader
{
  public static int ReadIntegers(string message)
  {
    int result;
    do
    {
      Console.Write(message);
    } while (!int.TryParse(Console.ReadLine(), out result));

    return result;
  }
}