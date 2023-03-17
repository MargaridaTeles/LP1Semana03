using System;
using AchievementsPlayer;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos players existem? ");
            int n = int.Parse(Console.ReadLine());

            achievements achievements;
            achievements[] players = new achievements[n];

            string questao;

            for (int i = 0; i < n; i++)
            {
                achievements = 0;
                Console.WriteLine($"Conquistas por jogadores {i + 1}: ");

                Console.WriteLine("O player derrotou o boss? (S/N)");
                questao = Console.ReadLine().ToUpper();
                if(questao == "S")
                {
                    achievements ^= achievements.DefeatOptionalBoss;
                }
                Console.WriteLine("O player achou o nivel escondido? (S/N)");
                questao = Console.ReadLine().ToUpper();
                if(questao == "S")
                {
                    achievements ^= achievements.FindHiddenLevel;
                }
                Console.WriteLine("O player acabou o jogo? (S/N)");
                questao = Console.ReadLine().ToUpper();
                if(questao == "S")
                {
                    achievements ^= achievements.FinishGame;
                }
                players[i] = achievements;
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Player {i + 1} achievements: ");
                if((int)players[i] > 0)
                {
                    Console.WriteLine(players[i]);
                    if((int)players[i]==7)
                    {
                        Console.WriteLine("Completionist!");
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}
