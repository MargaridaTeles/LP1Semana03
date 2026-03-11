using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string arg = args[0];

            Perks myPerks = 0;
            
            foreach (char c in arg)
            {
                switch (c)
                {
                    case 'a':
                        myPerks ^= Perks.AutoHeal;
                        break;

                    case 'w':
                        myPerks ^= Perks.WarpShift;
                        break;
                    
                    case 's':
                        myPerks ^= Perks.Stealth;
                        break;
                    
                    case 'd':
                        myPerks ^= Perks.DoubleJump;
                        break;

                    default:
                        Console.WriteLine("!Unknown Perk!");
                        return;
                }
                
            }

            if (myPerks != 0)
                Console.WriteLine(myPerks);
            else
                Console.WriteLine("!No perks at all!");

            if ((myPerks & Perks.DoubleJump) == Perks.DoubleJump && (myPerks & Perks.Stealth) == Perks.Stealth)
                Console.WriteLine("!Silent jumper!");

            if((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
                Console.WriteLine("!Not gonna make it!");

        }
    }
}
