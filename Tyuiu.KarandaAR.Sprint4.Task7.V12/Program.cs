using Tyuiu.KarandaAR.Sprint4.Task7.V12.Lib;

namespace Tyuiu.KarandaAR.Sprint4.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Работа со строками и матрицами                                    *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"658932125478\". Преобразуйте ее       *");
            Console.WriteLine("* в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                    *");
            Console.WriteLine("***************************************************************************");

            // Исходная строка
            string digits = "658932125478";

            // Преобразование строки в матрицу 3 на 4
            int rows = 4, cols = 3;
            int[,] matrix = new int[rows, cols];
            for (int i = 0, k = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++, k++)
                {
                    matrix[i, j] = digits[k] - '0'; // Преобразуем символ в число
                }
            }

            // Вывод матрицы
            Console.WriteLine("Преобразованная матрица 3x4:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();

            // Вывод результата
            Console.WriteLine($"Сумма нечетных чисел в матрице: {dataService.Calculate(3, 4, digits)}");
            Console.WriteLine("***************************************************************************");
        }
    }
}
