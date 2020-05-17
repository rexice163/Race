using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Animal
    {
        public int speed;
        public int position = 0;
        public int energyCurrent;
        public int energyMax;
        public string player;

        static Random generator = new Random();

        public void Move()
        {
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
