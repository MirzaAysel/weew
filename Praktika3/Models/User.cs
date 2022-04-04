using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika3.Interface;

namespace Praktika3.Models
{
    internal class User : IAccount
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        private string _password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        static User()
        {
            _id = 0;
        }
        private User()
        {
            Id = ++_id;
        }
        public User(string fullName, string email) : this()
        {
            Fullname = fullName;
            Email = email;
        }
      
        public bool PasswordChecker(string password)
        {
            if (password.Length<8)
            {
                return false;
            }
            bool checkUpper = false;
            bool checkLower = false;
            bool checkNum = false;

            foreach (var item in password)
            {
                if(char.IsUpper(item))
                {
                    checkUpper = true;
                }
                if (char.IsLower(item))
                {
                    checkLower = true;
                }
                if (char.IsDigit(item))
                    checkNum = true;
            }
            if(checkNum && checkLower && checkUpper)
            {
                return true;
            }
            return false;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Məlumatların düzgünlüyünü yoxlayın!");
            Console.WriteLine($"Id{Id}, FullName{Fullname}, Email{Email}");
        }
    }
}
