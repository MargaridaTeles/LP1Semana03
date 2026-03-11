using System;
using System.Linq;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SystemType systemType = Enum.Parse<SystemType>(Console.ReadLine());
            string[] tools = Console.ReadLine().Split();


            bool hasBruteForce = tools.Contains("BruteForce");
            bool hasPhishing = tools.Contains("Phishing");
            bool hasBackdoor = tools.Contains("Backdoor");
            bool hasZeroDay = tools.Contains("ZeroDay");
            bool hasAIOverride = tools.Contains("AIOverride");
            bool hasQuantumExploit = tools.Contains("QuantumExploit");

            bool hacked = false;

            switch (systemType)
            {
                case SystemType.CorporateServer:
                    hacked = (hasPhishing || hasBackdoor) && (hasBruteForce || hasZeroDay);
                    break;
                
                case SystemType.BankDatabase:
                    hacked = (hasZeroDay && hasBackdoor) || (hasQuantumExploit && hasAIOverride);
                    break;

                case SystemType.SmartCityCore:
                    hacked = (hasAIOverride && hasBackdoor) || (hasZeroDay && hasBruteForce) || (hasQuantumExploit && hasPhishing);
                    break;

                case SystemType.MilitaryAI:
                    hacked = (hasZeroDay && hasAIOverride) && (hasBackdoor || hasBruteForce) && (hasPhishing || hasQuantumExploit);
                    break;
            }

            Console.WriteLine(hacked ? "System Hacked" : "System Secure");


            /*string systemType = Console.ReadLine();
            string hackTools = Console.ReadLine();
            string[] hack = hackTools.Split(" ");
            
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
                foreach (string tool in hack)
                {
                    Console.WriteLine(tool);
                    if ((tool == phishing || tool == backdoor) && (tool == bruteForce || tool == zeroDay))
                        Console.WriteLine("System Hacked");
                    else
                        Console.WriteLine("System Secure");
                }
                
            }
            else if (systemType == bankDatabase)
            {
                foreach (string tool in hack)
                {
                    if ((tool == zeroDay && tool == backdoor) || (tool == quantumExploit && tool == aIOverride))
                        Console.WriteLine("System Hacked");
                    else
                        Console.WriteLine("System Secure");
                }
            }
            else if (systemType == smartCityCore)
            {
                foreach (string tool in hack)
                {
                    if ((tool == aIOverride && tool == backdoor) || (tool == zeroDay && tool == bruteForce) ||
                        (tool == quantumExploit && tool == phishing))
                        Console.WriteLine("System Hacked");
                }
            }
            else if (systemType == militaryAI)
            {
                foreach (string tool in hack)
                {
                    if ((tool == zeroDay && tool == aIOverride) && (tool == backdoor || tool == bruteForce) &&
                        (tool == phishing || tool == quantumExploit))
                        Console.WriteLine("System Hacked");
                    else
                        Console.WriteLine("System Secure");
                }
            }*/
        }
    }
}
