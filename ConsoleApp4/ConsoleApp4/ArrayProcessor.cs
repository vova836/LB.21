using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ArrayProcessor
    {
        // Асинхронный метод, возвращающий подмножество элементов массива, делящихся на 6
        public async void ProcessArray(int arraySize, Action<int[]> callback)
        {
            // Создаем массив случайных чисел
            int[] array = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(1, 100); // Для примера числа от 1 до 100
            }

            // Пауза для имитации долгого вычисления
            await Task.Delay(2000);

            // Формируем подмножество элементов массива, делящихся на 6
            int count = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] % 6 == 0)
                {
                    count++;
                }
            }

            int[] subset = new int[count];
            int index = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] % 6 == 0)
                {
                    subset[index] = array[i];
                    index++;
                }
            }

            // Вызываем обратное лямбда-выражение, передавая ему подмножество
            callback(subset);
        }
    }
}
