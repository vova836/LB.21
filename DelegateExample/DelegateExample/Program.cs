using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        // Определение пользовательского типа делегата
        public delegate double CustomDelegate(Func<Action<char>, bool, double, double> func);

        static void Main(string[] args)
        {
            // Создание экземпляра делегата
            CustomDelegate customDelegate = ExecuteMethods;

            // Вызов метода, передавая делегат
            double result = customDelegate(MethodToExecute);

            Console.WriteLine($"Результат выполнения методов: {result}");
        }

        // Метод, который будет передан делегату для выполнения
        static double MethodToExecute(Action<char> action, bool flag, double num)
        {
            // Выполнение переданного действия
            action('#');

            // Возврат результата в зависимости от флага
            return flag ? num * 2 : num / 2;
        }

        // Метод для выполнения нескольких действий
        static double ExecuteMethods(Func<Action<char>, bool, double, double> func)
        {
            Action<char> action = (c) => Console.WriteLine($"Действие выполнено с символом '{c}'");
            bool flag = true;
            double num = 10.5;

            // Вызов делегата с передачей параметров
            return func(action, flag, num);
        }
    }
}
