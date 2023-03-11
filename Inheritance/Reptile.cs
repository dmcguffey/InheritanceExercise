using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {

        public string scales { get; set; }
        public bool isVenomous { get; set; }

        public string tail { get; set; }

        public bool coldBlood { get; set; }
    }
}
