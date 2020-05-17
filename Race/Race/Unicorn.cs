using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Unicorn : Animal
    {
      //en konstruktor, så den får allt när den skapar
      public Unicorn()
      {
            speed = 10;
            energyCurrent = 10;
            energyMax = 10;
            player = "Unicorn";
      }
    }
}
