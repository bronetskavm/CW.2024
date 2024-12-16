using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_DB.Classes
{
    internal class Providers
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Contact;

        public Providers(int id, string name, string surname, string contact)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Contact = contact;
        }
    }
}
