using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Teddybear : Animal
    {
        //en konstruktor, så den får allt när den skapar
        public Teddybear()
        {
            speed = 5;
            energyCurrent = 5;
            energyMax = 5;
            player = "Teddybear";
        }

    }
}
