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

        static Random generator = new Random();

        void Move()
        {
            if(energyCurrent > 0)
            {
                position = position + generator.Next(speed);

                energyCurrent =- 1;
            }
            else
            {
                Console.WriteLine("Too tired to move");
            }
        }

        void Rest()
        {
            energyCurrent = energyMax;
        }

        void PrintStats()
        {

        }
    }
}
