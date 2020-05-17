using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Animal
    {
        //deras varaiabel
        public int speed;
        public int position = 0;
        public int energyCurrent;
        public int energyMax;
        //tar bort "race." när man väljer ut ett djur
        public string player;

        static Random generator = new Random();

        public void Move()
        {
            //den rör på sig med skalan på hur mycket speed den har och om den har energi för det
            if(energyCurrent > 0)
            {
                position += generator.Next(speed);

                energyCurrent--;
            }
            else
            {
                Console.WriteLine("Too tired to move");
            }

        }

        //den får tillbaka alla dens energi
        public void Rest()
        {
            energyCurrent = energyMax;
        }

        public void PrintStats()
        {
            Console.WriteLine("Speed: " + speed + "\nPosition: " + position + "\nEnergy: " + energyCurrent + "/" + energyMax);
        }
    }
}
