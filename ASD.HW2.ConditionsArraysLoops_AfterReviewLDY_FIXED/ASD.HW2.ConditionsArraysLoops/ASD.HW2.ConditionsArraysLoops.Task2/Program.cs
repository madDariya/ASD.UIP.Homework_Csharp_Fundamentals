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
            // LDY: мне показалось что эта штука работает странно. проверь, пожалуйста.
            // LDY: создай переменную с имеющимся количеством яиц для бросания
            // ASD: Да я пересмотрела, все работает по моей задумке, я построчно сейчас прокоментирую все,
            //      может я неправильно поняла смысл задачи
            //      Суть задачи в том чтобы определить за минимальное количество бросков на каком этаже разобьется яйцо
            //      Условие, что первое яйцо мы бросаем с шагом 14, умешьная его на 1 с каждой итерацией, второе с шагом 1. 
            //      В моей задаче мы бросаем яйцо 1 пока оно не разобьется, потом начинаем бросать второе
            //      Этаж на котором оно разбивается задаем рандомно
            Random randomizer = new Random();
            const int FLOORQUANTITY = 100;
            int floorWhereEggBreak = randomizer.Next(1,100);
            int dropEggCount = 0;
            int stepEgg1 = 14;
            for (int i = 14; i < FLOORQUANTITY + 1; i += stepEgg1)
            {
                //ASD: начинаем бежать по этажам, начиная с 14го. 
                //     Если не разбилось, то  шаг-1, +1 бросок и след итерация
                if (i < floorWhereEggBreak)
                {                   
                    dropEggCount++; //
                    --stepEgg1;
                }
                //ASD: Если на этом разбилось
                else if (i > floorWhereEggBreak)
                {
                    //ASD: начинаем бросать второе яйцо, начиная с предыдущего шага яйца 1 
                    for (int j = i - stepEgg1; j < i; j++)
                    {
                        if (j != floorWhereEggBreak) //ASD: и так идем и считаем броски пока не попадем на нужный этаж
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
                else if (i == floorWhereEggBreak) //ASD: на случай если мы первым яйцом сразу попадаем куда нужно
                {
                    Console.WriteLine($"Egg breaks on {floorWhereEggBreak} floor. " +
                                $"We did {dropEggCount} drops.");
                }
                // Console.Read();// LDY: ты запускала код? эта строк здесь должна быть или может за циклом?
                //ASD: это случайно

            }
            Console.Read();
        }
    }
}
