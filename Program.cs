using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika3.Models;

namespace Praktika3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Id, Fullname, Email;
            User user = new User("Aysel Mirze","mirzeaysel@gmail.com");

        ShowInfo:
          
            Console.WriteLine("====== User Menu ======\n" + "1. Show info\n" + "2. Create new group\n");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            Group group = new Group("AA101", 10);

        switch (choice)
            {
                case "1":
                    user.ShowInfo();
                    break;
                case "2":
                    string groupNo = "AA101";
                    int studentLimit = 10;
                    {

                        if (Group.CheckGroupNo("AA101") == true)
                        {
                            Console.WriteLine(groupNo);
                        }
                        if (studentLimit < 5 || studentLimit > 18);
                        {
                            Console.WriteLine();
                        } Console.WriteLine("Qrup uğurla yaradıldı");

                        Group group1 = new Group(groupNo, studentLimit);
                    }
                    bool check = true;
                   
                    break;

                    string groupChoice = Console.ReadLine();
                    switch (groupChoice)
                       
                    {
                       
                        case "1":
                            Console.WriteLine("Show all students");
                            group.GetAllStudents();
                        case "2":
                            Console.WriteLine(" Get student by id");
                            group.GetStudent();
                        case "3":

                    }

            }

        }

    }
}
