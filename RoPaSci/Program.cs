using System;

namespace RoPaSci
{
    public class Program
    {
        private static void Main(string[] args)
        {
            GameStatus result = RockPaperScissors(Enum.Parse<GameItem>(args[0]), Enum.Parse<GameItem>(args[1]));
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            GameItem rock = Enum.Parse<GameItem>("Rock");
            GameItem scissors = Enum.Parse<GameItem>("Scissors");
            GameItem paper = Enum.Parse<GameItem>("Paper");
            
            GameStatus result;

            bool player1Wins = (player1 == rock && player2 == scissors) ||
                               (player1 == scissors && player2 == paper) ||
                               (player1 == scissors && player2 == rock);

            if (player1 == player2)
                result = GameStatus.Draw; // Draw
            else if (player1Wins)
                result = GameStatus.Player1Wins; // Player 1 wins
            else
                result = GameStatus.Player2Wins; // Player 2 wins
            
            return result;
        }
    }
}
