using System;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*HackTool classTool;
            SystemType classSystem;*/

            string systemType = Console.ReadLine();
            string hackTools = Console.ReadLine();
            
            string corporateServer = SystemType.CorporateServer.ToString();
            string bankDatabase = SystemType.BankDatabase.ToString();
            string smartCityCore = SystemType.SmartCityCore.ToString();
            string militaryAI = SystemType.MilitaryAI.ToString();
            
            string bruteForce = HackTool.BruteForce.ToString();
            string phishing = HackTool.Phishing.ToString();
            string backdoor = HackTool.Backdoor.ToString();
            string zeroDay = HackTool.ZeroDay.ToString();
            string aIOverride = HackTool.AIOverride.ToString();
            string quantumExploit = HackTool.QuantumExploit.ToString();

            if (systemType == corporateServer)
            {
                if ((hackTools == phishing || hackTools == backdoor) && (hackTools == bruteForce || hackTools == zeroDay))
                    Console.WriteLine("System Hacked");
                else
                    Console.WriteLine("System Secure");
            }

            if (systemType == bankDatabase)
            {
                if ((hackTools == zeroDay && hackTools == backdoor) || (hackTools == quantumExploit && hackTools == aIOverride))
                    Console.WriteLine("System Hacked");
                else
                    Console.WriteLine("System Secure");
            }

            if (systemType == smartCityCore)
            {
                if ((hackTools == aIOverride && hackTools == backdoor) || (hackTools == zeroDay && hackTools == bruteForce) ||
                     (hackTools == quantumExploit && hackTools == phishing))
                    Console.WriteLine("System Hacked");
                else
                    Console.WriteLine("System Secure");
            }

            if (systemType == militaryAI)
            {
                if ((hackTools == zeroDay && hackTools == aIOverride) && (hackTools == backdoor || hackTools == bruteForce) &&
                     (hackTools == phishing || hackTools == quantumExploit))
                    Console.WriteLine("System Hacked");
                else
                    Console.WriteLine("System Secure");
            }

            Console.WriteLine(hackTools);
        }
    }
}
