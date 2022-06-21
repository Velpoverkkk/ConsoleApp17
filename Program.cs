using System;
class Program
{   //Задана матрица размером NxM.Упорядочить её  строки по возрастанию их первых элементов 
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M, n = 0, l=0,u=0,y=0,a;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 10);
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
        for (int k=0; k < N * M; k++)
        {
            for (int i = 0; i < N - 1; i++)
            {
                if (array[i, 0] > array[i + 1, 0])
                {

                    for (int j = 0; j < M; j++)
                    {
                        a = array[i, j];
                        array[i, j] = array[i + 1, j];
                        array[i + 1, j] = a;
                    }

                }
            }
        }
        System.Console.WriteLine();
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
    }
    
}
