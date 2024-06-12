using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Класс для сортировки списка студентов
    class Sorter
    {
        // Метод для сортировки списка студентов по имени
        public static void SortByName(List<Student> students)
        {
            students.Sort((s1, s2) => string.Compare(s1.Name, s2.Name));
        }

        // Метод для сортировки списка студентов по возрасту
        public static void SortByAge(List<Student> students)
        {
            students.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));
        }

        // Метод для сортировки списка студентов по успеваемости (средний балл)
        public static void SortByGPA(List<Student> students)
        {
            students.Sort((s1, s2) => s2.GPA.CompareTo(s1.GPA)); // Сортировка по убыванию
        }
    }
}
