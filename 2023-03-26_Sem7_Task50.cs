// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
// 17 -> такого числа в массиве нет

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите размер матрицы: ");
        int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        int[,] A = new int[size[0], size[1]];
        Random rand = new Random();
        for (int i = 0; i < A.GetLength(0); i++)
        {
            Console.WriteLine("\n");
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = rand.Next(1, 10); //случайные значения для элементов массива
                Console.Write("{0,5}", A[i, j]); //вывод массива
            }
        }

        Console.WriteLine();
        Console.Write("Введите число =  ");
        int N = Convert.ToInt32(Console.ReadLine());
        foreach (int elem in A)
        {
            if (elem == N)
            {
                Console.WriteLine(N);
            }
            else
            {
                Console.WriteLine("такого числа в массиве нет");
                    //вывод указания, что такого элемента нет                            
            }

        }
    }
}