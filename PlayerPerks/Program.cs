using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myperks = 0;
            foreach(char c in args[0])
            {
                if(c == 'w')
                {
                    myperks ^= Perks.WaterBreathing;
                }
                else if(c == 'a')
                {
                    myperks ^= Perks.AutoHeal;
                }
                else if(c == 's')
                {
                    myperks ^= Perks.Stealth;
                }
                else if(c == 'd')
                {
                    myperks ^= Perks.DoubleJump;
                }
                else
                {
                    Console.WriteLine("Unknow perk!");
                }
            }
            if(myperks == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else
            {
                Console.WriteLine($"Perks disponíveis: {myperks}");
            }
            if((int)(myperks & (Perks.Stealth | Perks.DoubleJump)) == 10)
            {
                Console.WriteLine("Silent jumper!");
            }
            if((int)(myperks & (Perks.AutoHeal)) == 0)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
