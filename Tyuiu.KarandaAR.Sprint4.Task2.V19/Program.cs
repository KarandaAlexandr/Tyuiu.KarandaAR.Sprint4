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

            int lenght = 14;
            int[] array = new int[lenght];

            Console.WriteLine("Введите значения:");

            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{i + 1}. ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Сумма равна: {dataService.Calculate(array)}");
        }
    }
}
