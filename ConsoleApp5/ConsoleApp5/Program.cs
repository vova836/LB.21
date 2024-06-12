using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем размер массива у пользователя
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            // Создаем задачу для генерации массива случайных чисел
            Task<int[]> generateTask = Task.Run(() => GenerateRandomArray(size));

            // Задача для вычисления количества элементов, делящихся на 3
            Task<int> divisibleBy3Task = generateTask.ContinueWith(task =>
            {
                int[] array = task.Result;
                int count = 0;
                foreach (var num in array)
                {
                    if (num % 3 == 0)
                        count++;
                }
                return count;
            });

            // Задача для поиска минимального элемента
            Task<int> minTask = generateTask.ContinueWith(task =>
            {
                int[] array = task.Result;
                int min = int.MaxValue;
                foreach (var num in array)
                {
                    if (num < min)
                        min = num;
                }
                return min;
            });

            // Ожидаем завершения всех задач продолжения
            Task.WaitAll(divisibleBy3Task, minTask);

            // Получаем результаты и выводим их
            int[] randomArray = generateTask.Result;
            int countDivisibleBy3 = divisibleBy3Task.Result;
            int minElement = minTask.Result;

            Console.WriteLine($"Массив случайных чисел: {string.Join(", ", randomArray)}");
            Console.WriteLine($"Количество элементов, делящихся на 3: {countDivisibleBy3}");
            Console.WriteLine($"Минимальный элемент: {minElement}");

            Console.ReadLine(); // Чтобы консольное приложение не закрылось сразу после выполнения
        }

        // Метод для генерации массива случайных чисел
        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); // Для примера числа от 1 до 100
            }
            return array;
        }
    }
}
