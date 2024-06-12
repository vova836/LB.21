using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // Определение типа делегата
        public delegate Task<int> MatrixOperationDelegate(int rows, int cols);

        static async Task Main(string[] args)
        {
            try
            {
                // Создание экземпляра делегата
                MatrixOperationDelegate matrixOperationDelegate = CalculateMinMaxDifference;

                // Задаем размер матрицы
                int rows = 5;
                int cols = 5;

                // Выполнение асинхронного метода с передачей параметров
                Console.WriteLine("Выполняется асинхронный метод...");
                Task<int> operationTask = matrixOperationDelegate(rows, cols);

                // Ожидание завершения выполнения метода
                int result = await operationTask;

                // Получение результата работы метода
                Console.WriteLine($"Разница между максимальным и минимальным элементами матрицы: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        // Асинхронный метод для вычисления разницы между максимальным и минимальным элементами матрицы
        static async Task<int> CalculateMinMaxDifference(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            // Заполнение матрицы случайными числами
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(1, 100); // Для примера числа от 1 до 100
                }
            }

            // Пауза для имитации долгого вычисления
            await Task.Delay(2000);

            // Нахождение максимального и минимального элементов матрицы
            int max = matrix[0, 0];
            int min = matrix[0, 0];

            foreach (int num in matrix)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }

            // Возвращаем разницу между максимальным и минимальным элементами
            return max - min;
        }
    }
}
