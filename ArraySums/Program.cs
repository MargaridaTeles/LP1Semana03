using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Solicite ao utilizador a dimensão horizontal e vertical de um array
            bidimensional de floats.
            Para cada posição i,j do array, solicitar um número real ao 
            utilizador e guarda-lo na respetiva posição do array
            Calcule a soma dos valores em cada linha e as apresente no ecrã
            Calcule a soma dos valores em cada coluna e a apresente no ecrã
            */
            Console.Write("Insira uma dimensão horizontal: ");
            string horizontal = Console.ReadLine();
            int horizontalnum = int.Parse(horizontal);
            Console.Write("Insira uma dimensão vertical: ");
            string vertical = Console.ReadLine();
            int verticalnum = int.Parse(vertical);
            float[,] array = new float[horizontalnum, verticalnum];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
