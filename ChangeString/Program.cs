using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira uma frase: ");
            string frase = Console.ReadLine();
            Console.Write("Insira um caracter: ");
            char carater = char.Parse(Console.ReadLine());

            foreach(char c in frase)
            {
                if(c!=carater)
                {
                    Console.Write(c);
                }
            }

        }
    }
}
