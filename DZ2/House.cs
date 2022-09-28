using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class House
    {
        private Flat[] _flats = new Flat[20];

        public House()
        {
            
        }

        public void GetInfo()
        {
            foreach(Flat amount in _flats)
            {
                Console.WriteLine(amount);
            }
        }
    }
}
