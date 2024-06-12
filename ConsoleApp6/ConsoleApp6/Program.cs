using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя путь к файлу с данными
            Console.Write("Введите путь к файлу с данными (если вводите с клавиатуры, оставьте пустую строку): ");
            string filePath = Console.ReadLine();

            List<Student> students = new List<Student>();

            if (string.IsNullOrWhiteSpace(filePath))
            {
                // Ввод данных с клавиатуры
                Console.WriteLine("Введите информацию о студентах (Имя Возраст Средний_балл):");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        break;

                    string[] data = input.Split();
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    double gpa = double.Parse(data[2]);
                    students.Add(new Student(name, age, gpa));
                }
            }
            else
            {
                // Чтение данных из файла
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split();
                            string name = data[0];
                            int age = int.Parse(data[1]);
                            double gpa = double.Parse(data[2]);
                            students.Add(new Student(name, age, gpa));
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка чтения файла: " + e.Message);
                    return;
                }
            }

            // Выбор критерия сортировки
            Console.WriteLine("Выберите критерий сортировки:");
            Console.WriteLine("1. По имени");
            Console.WriteLine("2. По возрасту");
            Console.WriteLine("3. По среднему баллу");
            Console.Write("Введите номер критерия: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Некорректный ввод. Введите номер критерия: ");
            }

            // Сортировка и вывод результатов
            switch (choice)
            {
                case 1:
                    Sorter.SortByName(students);
                    break;
                case 2:
                    Sorter.SortByAge(students);
                    break;
                case 3:
                    Sorter.SortByGPA(students);
                    break;
            }

            Console.WriteLine("Результаты сортировки:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
