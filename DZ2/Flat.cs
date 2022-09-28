using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Flat
    {
        private Person[] _people = new Person[2];

        public Flat()
        {

        }
        public void GetInfo()
        {
            foreach (Person person in _people)
            {
                Console.WriteLine($"{person}");
            }
        }

    }
}
