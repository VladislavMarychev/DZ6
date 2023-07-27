// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
using System;

namespace project
{
    class programm
    {

        static void Main(string[] args)
        {
            int Vvod(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            int m = Vvod("Введите количество строк ");
            int n = Vvod("Введите количество столбцов ");
            
            
            double[,] randomArray = new double[m, n];
            
            
            void massive(int m, int n)
            {
                int i, j;
                Random rand = new Random();
                for (i = 0; i < m; i++)
                {
                    Console.WriteLine();
                    for (j = 0; j < n; j++)
                    {
                        randomArray[i, j] = rand.NextDouble();
                        Console.Write($"{randomArray[i, j]:F1} ");
                    }

                }

            }



            massive(m, n);





        }
    }
}