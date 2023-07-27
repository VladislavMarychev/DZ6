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

            void massive(int m, int n)
            {
                int i, j;
                Random rand = new Random();
                double[,] randomArray = new double[m, n];
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


            void task1() // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
            {
                int m = Vvod("Введите количество строк ");
                int n = Vvod("Введите количество столбцов ");
                massive(m, n);

            }

            
            void task2()   // Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            {
                int m = 5;
                int n = 5;
                int i, j;
                Random rand = new Random();
                int[,] randomArray = new int[m, n];
                for (i = 0; i < m; i++)
                {
                    Console.WriteLine();
                    for (j = 0; j < n; j++)
                    {
                        randomArray[i, j] = rand.Next(0, 10);
                        Console.Write($"{randomArray[i, j]} ");
                    }
                }

                Console.WriteLine();
                int a = Vvod("Введите строку числа ");
                if (a <= m)
                {
                    int b = Vvod("Введите столбец числа ");

                    if (b <= n)
                    {
                        Console.WriteLine($"Выбрано число {randomArray[a - 1, b - 1]} ");
                    }
                    else
                    {
                        Console.WriteLine("Такого столбца в массиве нет");
                    }
                }
                else
                {
                    Console.WriteLine("Такой строки в массиве нет");
                }
            }

            //task2();


            void task3() //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            {
                int m = 5;
                int n = 5;
                int i, j;
                double sum = 0;
                Random rand = new Random();
                int[,] randomArray = new int[m, n];
                for (i = 0; i < m; i++)
                {
                    Console.WriteLine();
                    for (j = 0; j < n; j++)
                    {
                        randomArray[i, j] = rand.Next(0, 10);
                        Console.Write($"{randomArray[i, j]} ");
                    }
                }

                for (j = 0; j < n; j++)
                {

                    for (i = 0; i < m; i++)
                    {
                        sum = sum + randomArray[i, j];
                    }
                    Console.WriteLine();
                    Console.Write($"Среднее столба {j + 1}  {sum / i}");

                }
            }
            //task1();   // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
            //task2();   // Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            //task3();  //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        }


    }
}
