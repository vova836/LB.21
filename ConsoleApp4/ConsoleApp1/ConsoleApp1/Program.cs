using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список учеников
            StudentList studentList = new StudentList();

            // Добавляем несколько учеников
            studentList.AddStudent(new ConcreteStudent("Иван", "Иванов"));
            studentList.AddStudent(new ConcreteStudent("Петр", "Петров"));
            studentList.AddStudent(new ConcreteStudent("Сидор", "Сидоров"));

            // Поиск ученика по имени или фамилии
            Console.Write("Введите имя или фамилию для поиска: ");
            string keyword = Console.ReadLine();

            List<Student> searchResult = studentList.Search(keyword);

            if (searchResult.Count > 0)
            {
                Console.WriteLine("Результаты поиска:");
                foreach (var student in searchResult)
                {
                    student.Display();
                }
            }
            else
            {
                Console.WriteLine("Ничего не найдено.");
            }

            Console.ReadLine();
        }

    }
}

