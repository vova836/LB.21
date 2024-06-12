using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Строка для поиска символа
            string inputString = "Hello, World!";
            // Символ для поиска
            char searchChar = 'o';

            // Создаем параметризированный поток и передаем ему метод для выполнения
            Thread thread = new Thread(new ParameterizedThreadStart(FindCharacter));
            // Запускаем поток с передачей параметров
            thread.Start(new Tuple<string, char>(inputString, searchChar));

            Console.ReadLine(); // Чтобы консольное приложение не закрылось сразу после выполнения
        }

        // Метод для поиска символа в строке
        static void FindCharacter(object data)
        {
            // Распаковываем переданные параметры
            Tuple<string, char> tuple = (Tuple<string, char>)data;
            string inputString = tuple.Item1;
            char searchChar = tuple.Item2;

            // Поиск символа в строке
            bool exists = inputString.Contains(searchChar);

            // Вывод результата в консоль
            if (exists)
            {
                Console.WriteLine($"Символ '{searchChar}' найден в строке.");
            }
            else
            {
                Console.WriteLine($"Символ '{searchChar}' не найден в строке.");
            }
        }
    }
}
