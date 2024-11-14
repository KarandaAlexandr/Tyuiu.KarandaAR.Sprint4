using Tyuiu.KarandaAR.Sprint4.Task6.V24.Lib;

namespace Tyuiu.KarandaAR.Sprint4.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Компьютер\", \"Телефон\", \"Планшет\",         *");
            Console.WriteLine("* \"Принтер\", \"Сканер\", \"Монитор\", \"Клавиатура\"]. Используя класс Array, *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 7 символов.             *");
            Console.WriteLine("***************************************************************************");

            // Исходный массив
            string[] devices = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            // Вывод исходного массива
            Console.WriteLine("Изначальный массив:");
            foreach (string device in devices)
            {
                Console.WriteLine(device);
            }
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();

            // Вывод отфильтрованного массива
            foreach (string device in dataService.Calculate(devices))
            {
                Console.WriteLine(device);
            }
        }
    }
}
