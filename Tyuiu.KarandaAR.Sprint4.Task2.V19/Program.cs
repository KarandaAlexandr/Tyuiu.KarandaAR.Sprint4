using Tyuiu.KarandaAR.Sprint4.Task2.V19.Lib;

namespace Tyuiu.KarandaAR.Sprint4.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от 4 до 9. Подсчитать сумму нечетных  *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();

            int[] array = GenerateRandomArray(14, 4, 9);

            // Вывод массива
            Console.WriteLine("Сгенерированный массив:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"Сумма равна: {dataService.Calculate(array)}");
        }

        public static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] array = new int[length];
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(minValue, maxValue + 1);
        }

        return array;
    }
    }
}
