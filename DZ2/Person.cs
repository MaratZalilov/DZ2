using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Person
    {
        private string _Age;

        public Person()
        {
            _Age = "18";
        }

        public string GiveAge()
        {
            return _Age;
        }
    }
}
