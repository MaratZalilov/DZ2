using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class House
    {
        private Flat[] _flats;

        public House()
        {
            _flats = new Flat[20];
            for(int i = 0; i < _flats.Length; i++)
            {
                _flats[i] = new Flat();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"В этом доме {_flats.Length} квартир");
            Console.WriteLine("\t");
            for (int i = 0; i < _flats.Length;i++)
            {
                Console.WriteLine($"В квартире номер {i+1} жильцов");
                _flats[i].GetInfo();
                Console.WriteLine("\t");
            }
        }
    }
}
