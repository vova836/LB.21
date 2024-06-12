using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Размер массива
            int arraySize = 10;

            // Создаем задачу для расчета суммы элементов массива
            Task<int> sumTask = Task.Run(() => CalculateSum(arraySize));

            // Ожидаем завершения выполнения задачи и получаем результат
            int sum = sumTask.Result;

            Console.WriteLine($"Сумма элементов массива: {sum}");

            Console.ReadLine(); // Чтобы консольное приложение не закрылось сразу после выполнения
        }

        // Метод для расчета суммы элементов массива
        static int CalculateSum(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            // Заполнение массива случайными числами
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); // Для примера числа от 1 до 100
            }

            // Вычисление суммы элементов массива
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return sum;
        }
    }
}
