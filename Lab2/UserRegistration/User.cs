using System;
using System.Text.RegularExpressions;
using static ParserUtils.ParserUtil;

namespace UserRegistration
{
    class User
    {
        private readonly string _login;
        private readonly string _name;
        private readonly string _surname;
        private readonly int _age;
        private readonly DateTime _registrationDate;


        public User(string login, string name, string surname, int age)
        {
            _registrationDate = DateTime.Now;
            _login = login;
            _name = name;
            _surname = surname;
            _age = age;
        }

        public void UserInfo()
        {
            Console.WriteLine("User info: ");
            Console.WriteLine(
                $"Login: {_login}, name: {_name}, surname: {_surname}, age: {_age}, registration date: {_registrationDate}");
        }

        public static User CreateUser()
        {
            var login = ParseString("login");
            var name = ValidateAndParseRegex(NameRegex, "name");
            var surname = ValidateAndParseRegex(NameRegex, "surname");
            var age = ValidateAndParseIntRange("age", 0, 200);
            return new User(login, name, surname, age);
        }
    }
}