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
            int horizontal = int.Parse(Console.ReadLine());
            Console.Write("Insira uma dimensão vertical: ");
            int vertical = int.Parse(Console.ReadLine());
            float[,] array = new float[vertical, horizontal];

            float somalinhas = 0;
            float[] somacolunas = new float[vertical];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Insira um valor para ({i + 1},{j + 1}) posição: ");
                    array[i, j] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                somalinhas = 0;
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    somalinhas += array[i, j];
                    somacolunas[j] += array[i, j];
                }
                Console.WriteLine($"A soma da {i + 1}ª linha é: {somalinhas}");
            } 

            for (int i = 0; i < somacolunas.Length; i++)
            {
                Console.WriteLine($"A soma da {i + 1}ª coluna é: {somacolunas[i]}");
            }

        }
    }
}
