using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string answer = Console.ReadLine();

            
            Console.Write("Caráter: ");
            char caracter = char.Parse(Console.ReadLine());

            char x = 'x';
            string answerUpdate = "";

            foreach (char s in answer)
            {
                if (s == caracter)
                    answerUpdate += x;
                else
                    answerUpdate += s;
            }
            
            Console.WriteLine($"Será impresso: {answerUpdate}");
        }
    }
}
