using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Flat
    {
        private Person[] _people;

        public Flat()
        {
            _people = new Person[2];
            for (int i = 0; i < _people.Length; i++)
            {
                Random rnd = new Random();
                int age = rnd.Next(18, 55);
                _people[i] = new Person(age);
            }
        }
        public void GetInfo()
        {
            foreach (Person person in _people)
            {
                person.GetInfo();
            }
        }

    }
}
