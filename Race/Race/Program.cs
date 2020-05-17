using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int round = 0;

            List<Animal> aniList = new List<Animal>();
            while (true)
            {
                Console.WriteLine("How many creatures do you want?");

                string answer = Console.ReadLine();

                bool success = int.TryParse(answer, out int answer2);

                if (success && answer2 > 0)
                {
                    for (int i = 0; i < answer2; i++)
                    {
                        int aniNumber = generator.Next(2);
                        if (aniNumber == 0)
                        {
                            Console.WriteLine("Created a Unicorn");
                            aniList.Add(new Unicorn());
                            aniList[i].PrintStats();
                        }

                        else if (aniNumber == 1)
                        {
                            Console.WriteLine("Created a Teddybear");
                            aniList.Add(new Teddybear());
                            aniList[i].PrintStats();
                        }

                        Console.WriteLine("______________________________________________");
                    }

                    Console.WriteLine("Press any key to you continue!");

                    Console.ReadKey();

                    break;
                }
                else if (success)
                {
                    Console.WriteLine("Something above 0");
                }
                else
                {
                    Console.WriteLine("Mate, write a number");
                }

                Console.Clear();


                Animal priAnimal = aniList[generator.Next(aniList.Count)];

                Console.WriteLine("The chosen animal is");
                Console.WriteLine(priAnimal.player);

                Console.WriteLine("Press any key to start the race!");

                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Round: " + round);
                    priAnimal.PrintStats();
                    Console.WriteLine("________________________________________");

                    while (true)
                    {
                        Console.WriteLine("Choose an option.");
                        Console.WriteLine("1 = Move, 2 = Rest");

                        string answer3 = Console.ReadLine();

                        int.TryParse(answer3, out int answer4);
                        if (answer4 == 1)
                        {
                            priAnimal.Move();
                            break;
                        }
                        else if (answer4 == 2)
                        {
                            priAnimal.Rest();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("mate, 1 or 2");
                        }
                    }
                    if (priAnimal.position == 20)
                    {
                        Console.WriteLine("Congratulations! It's over");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        round++;
                    }

                    Console.Clear();
                }
            }
        }
    }
}
