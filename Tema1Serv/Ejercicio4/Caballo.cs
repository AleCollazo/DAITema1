using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Horse
    {
        public int Id { get; set; }
        public Random Random { get; set; }

        public Horse(int id, Random rand)
        {
            Id = id;
            Random = rand;
        }


    }
}
