using Praktika3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika3
{
    internal class Group
    {
        public int id { get; }
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }
      
        public int StudentLimit
        {
            get
            {
                return StudentLimit;
            }
            set
            {
                if (value >=5 && value < 18)
                {
                    StudentLimit = value;
                }

            }
        }

        private static Student[] students;
        static Group()
        {
            students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Siz tələbə limitinə çatdınız");
            }

        }
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5)
            {
                if (char.IsLetter(groupNo[0]) && char.IsLetter(groupNo[1]))
                {
                    if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                    { return true; }
                }
            }       return false;
        }

        public Student GetStudent(int id)
        {
            if (id != null && students.Length > 0)
            {
                foreach (var student in students)
                {
                    if (student.Id == id)
                        return student;
                }
            }

            return null;
        }
        public Student[] GetAllStudents()
        {
            return students;
        }
    }

}

