using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StudentList
    {
        private List<Student> students = new List<Student>();

        // Метод для добавления студента в список
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Метод для поиска ученика по имени или фамилии
        public List<Student> Search(string keyword)
        {
            List<Student> result = new List<Student>();

            foreach (var student in students)
            {
                if (student.FirstName.ToLower().Contains(keyword.ToLower()) ||
                    student.LastName.ToLower().Contains(keyword.ToLower()))
                {
                    result.Add(student);
                }

            }

            return result;
        }
    }
}
