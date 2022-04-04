using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika3.Models
{
    internal class Student
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public int Point { get; set; }
        static Student()
        {
            _id = 0;
        }
        private Student()
        {
            Id = ++_id;
        }
        public Student(string fullName, int point) : this()
        {
            Fullname = fullName;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine("Məlumatların düzgünlüyünü yoxlayın!");
            Console.WriteLine($"Id{Id}, FullName{Fullname}, Point{Point}");
           
        }
    }
}
