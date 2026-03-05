using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // --------- Arrays de Arrays ---------
            float[][] A = new float[2][];
            A[0] = new float[2];
            A[1] = new float[2];

            float[][] B = new float[2][];
            B[0] = new float[1];
            B[1] = new float[1];

            float[][] R = new float[2][];
            R[0] = new float[1];
            R[1] = new float[1];

            int index = 0;
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i][j] = float.Parse(args[index]);
                    index++;
                }
            }
            
            /*Console.WriteLine($"| {A[0][0]}, {A[0][1]} |");
            Console.WriteLine($"| {A[1][0]}, {A[1][1]} |");*/

            for (int i = 0; i < 2; i++)
            {
                B[i][0] = float.Parse(args[index]);
                index++;
            }

            for (int i = 0; i < 2; i++)
            {
                R[i][0] = A[i][0] * B[0][0] +
                          A[i][1] * B[1][0];
            }

            for (int i = 0; i < 2; i++)
                Console.WriteLine($"| {R[i][0],7:F2} |");

            
            // --------- Arrays Multi ---------
            float [ , ] matrixA = new float[2, 2];
            float [ , ] matrixB = new float[2, 1];

            float [ , ] result = new float [2, 1];


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
