using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public int legs { get; set; }
        public bool isAlive { get; set; }

        public string noise { get; set; }

        public void makeNoise()
        {
            Console.WriteLine (noise);
        }

    }
}
