using Tyuiu.KarandaAR.Sprint4.Task3.V26.Lib;

namespace Tyuiu.KarandaAR.Sprint4.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 6. Найдите максимальный     *");
            Console.WriteLine("* элемент во второй строке массива.                                       *");
            Console.WriteLine("* Массив:                                                                 *");
            Console.WriteLine("* {4, 3, 2, 6, 2},                                                        *");
            Console.WriteLine("* {5, 2, 2, 5, 6},                                                        *");
            Console.WriteLine("* {2, 5, 4, 5, 6},                                                        *");
            Console.WriteLine("* {4, 5, 2, 4, 6},                                                        *");
            Console.WriteLine("* {6, 5, 4, 3, 6}                                                         *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { 4, 3, 2, 6, 2 },
                { 5, 2, 2, 5, 6 },
                { 2, 5, 4, 5, 6 },
                { 4, 5, 2, 4, 6 },
                { 6, 5, 4, 3, 6 }
            };

            Console.WriteLine($"Максимальный элемент: {dataService.Calculate(matrix)}");
            Console.ReadKey();
        }
    }
}
