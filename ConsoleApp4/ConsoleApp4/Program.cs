using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Размер исходного массива
            int arraySize = 10;

            // Создаем экземпляр класса, отвечающего за работу с массивом
            ArrayProcessor arrayProcessor = new ArrayProcessor();

            // Асинхронный вызов метода с обратным вызовом через лямбда-выражение
            arrayProcessor.ProcessArray(arraySize, (subset) =>
            {
                Console.WriteLine("Получено подмножество элементов массива:");
                foreach (var item in subset)
                {
                    Console.Write(item + " ");
                }
            });

            Console.WriteLine("Ожидание завершения асинхронной операции...");
            Console.ReadLine(); // Чтобы консольное приложение не закрылось сразу после выполнения
        }
    }
}
