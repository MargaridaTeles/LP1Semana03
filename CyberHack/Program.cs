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
        }
    }
}
