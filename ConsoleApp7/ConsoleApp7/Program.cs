using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        // Делегат для представления метода вычисления среднего арифметического
        public delegate void CalculateAverageDelegate(int[] array);

        static void Main(string[] args)
        {
            // Создаем массив для хранения потоков
            Thread[] threads = new Thread[5]; // Пример размера массива

            // Создаем экземпляр делегата, указывая метод для вычисления среднего арифметического
            CalculateAverageDelegate calculateAverageDelegate = CalculateAverage;

            // Запускаем все потоки на выполнение
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => calculateAverageDelegate(new int[] { 1, 2, 3, 4, 5 })); // Пример массива чисел
                threads[i].Start();
            }

            Console.ReadLine(); // Чтобы консольное приложение не закрылось сразу после выполнения
        }

        // Метод для вычисления среднего арифметического элементов массива
        static void CalculateAverage(int[] array)
        {
            double sum = 0;

            foreach (var num in array)
            {
                sum += num;
            }

            double average = sum / array.Length;

            Console.WriteLine($"Среднее арифметическое элементов массива: {average}");
            Console.ReadKey();
        }
    }
}
