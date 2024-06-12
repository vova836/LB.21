using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class MatrixProcessor
    {
        private const int MatrixSize = 5; // Размер матрицы
        private const int ThreadCount = 3; // Количество потоков в пуле

        // Метод для обработки матрицы с использованием пула потоков
        public void ProcessMatrixWithThreadPool()
        {
            // Создаем и запускаем потоки из пула
            for (int i = 0; i < ThreadCount; i++)
            {
                ThreadPool.QueueUserWorkItem(ProcessMatrix);
            }
        }

        // Метод для обработки матрицы в отдельном потоке
        private void ProcessMatrix(object state)
        {
            // Генерируем матрицу случайных чисел
            int[,] matrix = GenerateRandomMatrix();

            // Вычисляем среднее арифметическое элементов матрицы
            double average = CalculateAverage(matrix);

            // Выводим результат в консоль
            Console.WriteLine($"Среднее арифметическое элементов матрицы: {average}");

            // Задержка для имитации работы
            Thread.Sleep(1000);
        }

        // Метод для генерации матрицы случайных чисел
        private int[,] GenerateRandomMatrix()
        {
            Random random = new Random();
            int[,] matrix = new int[MatrixSize, MatrixSize];
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    matrix[i, j] = random.Next(1, 100); // Для примера числа от 1 до 100
                }
            }
            return matrix;
        }

        // Метод для вычисления среднего арифметического элементов матрицы
        private double CalculateAverage(int[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum / (MatrixSize * MatrixSize);
        }
    }
}

