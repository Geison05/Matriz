using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // instancia matriz
            int[,] mat = new int[n, n];
            // inicio da matriz
            for (int i = 0; i < n; i++)
            {// entrada de dados com split de espaço
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            } // fim da matriz
            // Imprimi diagonal 
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            // quntos nagativos contem 
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Negative number: "+ cont);
        }
    }
}