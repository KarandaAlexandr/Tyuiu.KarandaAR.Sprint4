using Tyuiu.KarandaAR.Sprint4.Task4.V29.Lib;

namespace Tyuiu.KarandaAR.Sprint4.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями в диапазоне от 4 до 8, введёнными с клавиатуры.              *");
            Console.WriteLine("* Найдите сумму четных элементов массива.                                 *");
            Console.WriteLine("* Пример массива:                                                         *");
            Console.WriteLine("* {5, 6, 5, 6, 5}                                                         *");
            Console.WriteLine("* {5, 5, 5, 8, 4}                                                         *");
            Console.WriteLine("* {8, 5, 5, 8, 8}                                                         *");
            Console.WriteLine("* {6, 5, 4, 4, 8}                                                         *");
            Console.WriteLine("* {8, 5, 6, 8, 8}                                                         *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();

            int[,] matrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма четных элементов массива: {dataService.Calculate(matrix)}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
