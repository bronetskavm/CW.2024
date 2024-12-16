using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_DB.Classes
{
    internal class Accounts
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Password;
        public string Position;

        public Accounts(int id, string name, string surname, string password, string position)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Password = password;
            Position = position;
        }
    }
}
