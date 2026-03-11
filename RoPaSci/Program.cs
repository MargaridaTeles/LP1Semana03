using System;

namespace RoPaSci
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            int result;

            if (player1 == player2)
                result = 0; // Draw

            bool player1Wins = (player1 == "Rock" && player2 == "Scissors") ||
                               (player1 == "Scissors" && player2 == "Paper") ||
                               (player1 == "Paper" && player2 == "Rock");

            if (player1Wins)
                result = 1; // Player 1 wins
            else
                result = 2;
            
            return result; // Player 2 wins
        }
    }
}
