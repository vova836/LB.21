using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса для обработки матрицы
            MatrixProcessor processor = new MatrixProcessor();

            // Выполняем метод обработки матрицы с использованием пула потоков
            processor.ProcessMatrixWithThreadPool();

            Console.ReadLine(); // Чтобы консольное приложение не закрылось сразу после выполнения
        }
    }
}
