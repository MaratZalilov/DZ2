using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Person
    {
        private int _age;

        public Person(int age)
        {
            _age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Возвраст жильца {_age}");
        }
    }
}
