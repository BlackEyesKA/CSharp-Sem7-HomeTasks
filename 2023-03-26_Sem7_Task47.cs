// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] A = new double[size[0], size[1]];
            Random random = new Random();
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < A.GetLength(1); ++j)
                {
                    A[i, j] = random.Next(-10,10);
                    Console.Write("{0,5}", A[i, j]);
                }
            }