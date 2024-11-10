using Tyuiu.KarandaAR.Sprint4.Task1.V28.Lib;

namespace Tyuiu.KarandaAR.Sprint4.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            
            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Таск #1                                                                 *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 6. Подсчитать произведение  *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("* Ввод: 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4                          *");
            Console.WriteLine("***************************************************************************");

            int lenght = 14;
            int[] array = new int[lenght];

            Console.WriteLine("Введите значения:");

            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{i + 1}. ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Произведение равно: {dataService.Calculate(array)}");
        }
    }
}
