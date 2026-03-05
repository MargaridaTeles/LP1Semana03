using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Arrays de Arrays
            float[][] matrix = new float[4][];

            // Arrays Multi
            float [ , ] matrixA = new float[2, 2];
            float [ , ] matrixB = new float[2, 1];

            float [ , ] result = new float [2, 1];

            if (args.Length < 6)
            {
                Console.WriteLine("Erro: são necessários 6 argumentos numéricos.");
                return;
            }


            int contador = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrixA[i,j] = float.Parse(args[contador]);
                    contador++;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                matrixB[i, 0] = float.Parse(args[contador]);
                contador++;
            }

            for (int i = 0; i < 2; i++)
            {
                result[i , 0] = matrixA[i, 0] * matrixB[0, 0] +
                                matrixA[i, 1] * matrixB[1, 0];
            }

            for (int i = 0; i < 2; i++)
                Console.WriteLine($"| {result[i, 0],7:F2} |");

            /* ---------------- DEBUG ----------------
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(matrixA[i, j]);
            }

            Console.WriteLine("");

            for (int i = 0; i < 2; i++)
                Console.WriteLine(matrixB[i, 0]);
            */
        }
    }
}
