﻿using System.Numerics;
using Tyuiu.KarandaAR.Sprint4.Task5.V11.Lib;

namespace Tyuiu.KarandaAR.Sprint4.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 2. Заменить положительные    *");
            Console.WriteLine("* элементы на 1.                                                          *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();

            int[,] matrix = {
                { -3, 1, 0, -6, 2 },
                { -7, -2, 1, 2, -4 },
                { 2, -5, -3, 1, 0 },
                { -6, 2, -1, -3, 2 },
                { 1, 0, -7, 2, -4 }
            };

            // Вывод изначальной матрицы
            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            // Обработка массива
            matrix = dataService.Calculate(matrix);

            // Вывод обработанной матрицы
            Console.WriteLine("\nОбработанный массив:");
            PrintMatrix(matrix);

            // Функция для вывода матрицы в консоль
            void PrintMatrix(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}