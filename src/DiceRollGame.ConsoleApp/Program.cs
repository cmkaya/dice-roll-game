using DiceRollGame.ConsoleApp.Logic;

var guessingGame = new GuessingGame(new Dice());
var gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);