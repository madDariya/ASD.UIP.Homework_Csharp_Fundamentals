using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD.HW2.ConditionsArraysLoops.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            const int FLOORQUANTITY = 100;
            int floorWhereEggBreak = randomizer.Next(1,100);
            int dropEggCount = 0;
            int stepEgg1 = 14;
            for (int i = 14; i < FLOORQUANTITY + 1; i += stepEgg1)
            {

                if (i < floorWhereEggBreak)
                {                   
                    dropEggCount++;
                    --stepEgg1;
                }
                else if (i > floorWhereEggBreak)
                {
                    for (int j = i - stepEgg1; j < i; j++)
                    {
                        if (j != floorWhereEggBreak)
                        {
                            dropEggCount++;
                        }
                        else
                        {
                            Console.WriteLine($"Egg breaks on {floorWhereEggBreak} floor. " +
                                $"We did {dropEggCount} drops.");
                        }
                    }

                }
                else if (i == floorWhereEggBreak)
                {
                    Console.WriteLine($"Egg breaks on {floorWhereEggBreak} floor. " +
                                $"We did {dropEggCount} drops.");
                }
                Console.Read();

            }
        }
    }
}
