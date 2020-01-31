using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class User
    {
        string name;
        int age;

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }


    }
}
