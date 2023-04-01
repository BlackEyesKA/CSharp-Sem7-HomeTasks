// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

class Program
    {
        static void Main(string[] args)
        {
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
                            A[i, j] = random.Next(1,10); //случайные значения для элементов массива
                            Console.Write("{0,5}", A[i, j]); //вывод массива
                        }
                    }

        double [] arithmeticMean = new double[A.GetLength(1)];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                double temp = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    temp += A[i,j]; //подсчет суммы колонки
                    arithmeticMean[j] = temp / A.GetLength(0); //cреднее арифметическое столбца                
                }                
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < A.GetLength(1); i++)
                {
                    
                    Console.Write("{0,5}", Math.Round(arithmeticMean[i], 2)); //вывод среднего для колонки
                }
                
            
    }
}