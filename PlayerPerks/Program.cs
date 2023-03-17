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
                if(c=='w')
                {
                    myperks ^= Perks.WaterBreathing;
                }
                else if(c=="a")
                {
                    myperks ^= Perks.AutoHeal;
                }
                else if(c=="s")
                {
                    myperks ^= Perks.Stealth;
                }
                else if(c=="d")
                {
                    myperks ^= Perks.DoubleJump;
                }
                else
                {
                    Console.WriteLine("Unknow perk!");
                }
            }
        }
    }
}
