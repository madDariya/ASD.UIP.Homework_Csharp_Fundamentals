using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASD.HW2.ConditionsArraysLoops.Task1
{
    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK1\n");
            int intA = randomizer.Next(-50, 50);
            // LDY: в одну строку с тернарн оператором переписать можно
            // ASD: переписала ниже
            string resultTask1 = intA > 0 ? "positive" : "negative";
            Console.WriteLine($"The number {intA} is {resultTask1}");

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK2\n");
            // LDY: в одну строку с тернарн оператором переписать можно
            // ASD: переписала ниже, старый вариант с ифом убрала
            string resultTask2 = intA % 2 != 0 ? "even" : "odd";
            Console.WriteLine($"The number {intA} is {resultTask2}", intA);

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK3\n");
            int intB = randomizer.Next(-50, 50);
            int intC = randomizer.Next(-50, 50);
            // LDY: в одну строку с тернарн оператором переписать можно
            // ASD: переписала ниже, старый вариант с ифом убрала
            string resultTask3 = intA < intB && intB < intC ? "true" : "false";
            Console.WriteLine($"Double inequality {intA} < {intB} < {intC} is {resultTask3}");

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK4\n");
            // LDY: в одну строку с тернарн оператором переписать можно
            // ASD: done
            string resultTask4 = intA > 0 || intB > 0 || intC > 0 ? $"At least one of numbers A = {intA}, B = {intB}, or C = {intC}" +
                  $" is positive" : $"No positive numbers.Check:/nA = {intA}, B = {intB}, or C = {intC}";
            Console.WriteLine(resultTask4);

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK5\n");
            // LDY: в одну строку с тернарн оператором переписать можно
            //ASD: done
            string resultTask5 = intA > 0 ^ intB > 0 ^ intC > 0 ? "Only one" : "More than 1 or no one";
            Console.WriteLine($"{resultTask5} of numbers A = {intA}, B = {intB}, or C = {intC}" +
                $" is positive");

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK6\n");
            int randomIntValue = randomizer.Next(999);
            // LDY: в одну строку с тернарн оператором переписать можно
            //ASD: done
            string resultTask6 = randomIntValue > 99 && randomIntValue % 2 != 0 ? "IS" : "IS NOT";
            Console.WriteLine($"The value {randomIntValue} {resultTask6} three-digit odd number");

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK7\n");
            int Vertex1X = randomizer.Next(-50, 50);
            int Vertex1Y = randomizer.Next(-50, 50);
            int Vertex2X = randomizer.Next(-50, 50);
            int Vertex2Y = randomizer.Next(-50, 50);
            int randomPoint1X = randomizer.Next(-50,50);
            int randomPoint1Y = randomizer.Next(-50, 50);
            int biggerVertexX;
            int biggerVertexY;
            int smallerVertexX;
            int smallerVertexY;
            bool tempResultX;
            bool tempResultY;
            string resultTask7;
            Console.WriteLine($"x1 = {Vertex1X}, y1 = {Vertex1Y}, x2 = {Vertex2X}, y2 = {Vertex2Y}" +
                $", x = {randomPoint1X}, y = {randomPoint1Y}");
            //-----------BAD VARIANT-------------- (вытерла весь этот позор ниже позор)
            // LDY: да, плохо, логику бы переписать и упростить. много копипаста.вообще как-то сложно все получилось в простом задании
            //ASD: в прошлый раз усложнила слишком все, но чтобы упростить нужно ввести доп. переменные, в которых мы
            //       определеним координаты какой точки больше и какой меньше, чтобы адекватно писать сравнение для точки которая лежит
            //       в нашем прямоугольнике. Если этого не сделать, то мы можем сравнивать бессмыслицу (больше бОльшей стороны
            //       и меньше меньшей). Надеюсь идею норм объяснила, по другому не знаю как сделать
            biggerVertexX = Vertex1X > Vertex2X ? Vertex1X : Vertex2X;
            smallerVertexX = Vertex1X < Vertex2X ? Vertex1X : Vertex2X;
            biggerVertexY = Vertex1Y > Vertex2Y ? Vertex1Y : Vertex2Y;
            smallerVertexY = Vertex1Y < Vertex2Y ? Vertex1Y : Vertex2Y;
            tempResultX = randomPoint1X > smallerVertexX && randomPoint1X < biggerVertexX;
            tempResultY = randomPoint1Y > smallerVertexY && randomPoint1Y < biggerVertexY;
            resultTask7 = tempResultX && tempResultY ? "IS" : "IS NOT";
            Console.WriteLine($"Point {resultTask7} situated in rectangle");

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK8\n");
            int triangleSideA = randomizer.Next(50);
            int triangleSideB = randomizer.Next(50);
            int triangleSideC = randomizer.Next(50);
            // LDY: в одну строку с тернарн оператором переписать можно
            // LDY: вынести отдельную переменную - не пиши внутрь ифа длинные выражения
            // ASD: а так можно? Или эту большое сравнение раздробить по переменным?
            string resultTask8 = triangleSideA + triangleSideB > triangleSideC && triangleSideB + triangleSideC >
               triangleSideA && triangleSideA + triangleSideC > triangleSideB ? "FORM" : "NOT FORM";
            Console.WriteLine($"Side A = {triangleSideA}, side B = {triangleSideB}," +
                $"side C = {triangleSideC} {resultTask8} a triangle.");
           
            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK9\n");
            int chessFieldCellX = randomizer.Next(0, 9);
            int chessFieldCellY = randomizer.Next(0, 9);
            bool resultX = chessFieldCellX % 2 == 0;
            bool resultY = chessFieldCellY % 2 == 0;
            if (resultX && resultY)
            {
                Console.WriteLine($"The cell X = {chessFieldCellX}, Y = {chessFieldCellY} " +
                    $"is white");
            }
            else
            {
                Console.WriteLine($"The cell X = {chessFieldCellX}, Y = {chessFieldCellY} " +
                    $"is black");
            }

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK10\n");
            int chessFieldCell2X = randomizer.Next(0, 9);
            int chessFieldCell2Y = randomizer.Next(0, 9);
            if(chessFieldCellX==chessFieldCell2X || chessFieldCellY==chessFieldCell2Y 
                || chessFieldCell2X - chessFieldCellX == chessFieldCell2Y - chessFieldCellY 
                || chessFieldCell2X + chessFieldCellX == chessFieldCell2Y + chessFieldCellY)
            {
                Console.WriteLine($"A queen CAN move from one field to another in one move");
            }
            else
            {
                Console.WriteLine($"A queen CAN NOT move from one field to another in one move");
            }
            Console.WriteLine("___________________________________");

            Console.WriteLine("TASK11\n");
            int NumberA = randomizer.Next(-50, 50);
            int NumberB = randomizer.Next(-50, 50);
            Console.WriteLine($"Number A = {NumberA}, number B = {NumberB}");
            NumberA += NumberB;
            NumberB = NumberA - NumberB;
            NumberA -= NumberB;
            Console.WriteLine($"After swap: number A = {NumberA}, number B = {NumberB}");
            Console.WriteLine("___________________________________");

            Console.WriteLine("TASK12\n");
            int randomWeekDayNumber = randomizer.Next(1, 7);
            string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
            "Saturday" , "Sunday"};
            if (randomWeekDayNumber == 1)
                Console.WriteLine($"{randomWeekDayNumber} day on week is {weekDays[randomWeekDayNumber-1]}");
            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK13\n");
            int randomMark= randomizer.Next(1, 5);
            string[] marks = { "REALLY BAD", "BAD", "OK", "GOOD", "EXELLENT" };
            Console.WriteLine($"The mark {randomMark} is {marks[randomMark-1]}!");
            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK14\n");
            int calculusMeasure = randomizer.Next(1, 5);
            int sectionLength = randomizer.Next(100, 1000000);

            // LDY: switch или if else - у тебя же одновременно не могут все ифы выполниться поэтому на каждое условие иф писать не имеет смысла
            // ASD: fixed
            if (calculusMeasure == 1)
            {
                Console.WriteLine($"{sectionLength}dm  is {sectionLength * 10}m");
            }
            else if (calculusMeasure == 2)
            {
                Console.WriteLine($"{sectionLength}km  is {sectionLength * 1000}m");
            }
            else if (calculusMeasure == 3)
            {
                Console.WriteLine($"{sectionLength}m  is {sectionLength}m");
            }
            else if (calculusMeasure == 4)
            {
                Console.WriteLine($"{sectionLength}mm  is {sectionLength/1000}m");
            }
            else if (calculusMeasure == 1)
            {
                Console.WriteLine($"{sectionLength}sm  is {sectionLength/100}m");
            }
            Console.WriteLine("___________________________________");

            Console.WriteLine("TASK15\n");
            // LDY: можно и нужно упростить логику самого решения
            // ASD: упростила, по поповду свича, знаю так не надо писать, просто так компактнее выглядит
            int randomNumber = randomizer.Next(1, 99);
            string resultTask15 = "";
            if (randomNumber > 19 && randomNumber < 100)
            {
                switch (randomNumber / 10)
                {
                    case 2: resultTask15 += "twenty"; break;
                    case 3: resultTask15 += "thirty"; break;
                    case 4: resultTask15 += "fourty"; break;
                    case 5: resultTask15 += "fifty"; break;
                    case 6: resultTask15 += "sixty"; break;
                    case 7: resultTask15 += "seventy"; break;
                    case 8: resultTask15 += "eighty"; break;
                    case 9: resultTask15 += "ninety"; break;
                }
            }
            if (randomNumber < 10 || randomNumber > 19 && randomNumber < 100)
            {
                switch(randomNumber % 10)
                {
                    case 0: resultTask15 += ""; break;
                    case 1: resultTask15 += " one"; break;
                    case 2: resultTask15 += " two"; break;
                    case 3: resultTask15 += " three"; break;
                    case 4: resultTask15 += " four"; break;
                    case 5: resultTask15 += " five"; break;
                    case 6: resultTask15 += " six"; break;
                    case 7: resultTask15 += " seven"; break;
                    case 8: resultTask15 += " eight"; break;
                    case 9: resultTask15 += " nine"; break;
                }
            }
            else if (randomNumber > 9 && randomNumber < 20)
            {
                switch (randomNumber % 10)
                {
                    case 0: resultTask15 += "ten"; break;
                    case 1: resultTask15 += "eleven"; break;
                    case 2: resultTask15 += "twelve"; break;
                    case 3: resultTask15 += "thirteen"; break;
                    case 4: resultTask15 += "fourteen"; break;
                    case 5: resultTask15 += "fifteen"; break;
                    case 6: resultTask15 += "sixteen"; break;
                    case 7: resultTask15 += "seventeen"; break;
                    case 8: resultTask15 += "eighteen"; break;
                    case 9: resultTask15 += "nineteen"; break;
                }
            }
            Console.WriteLine($"{randomNumber}  {resultTask15}");
           
            // OLD BAD VARIANT
            //string[] numbers = {" ", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            //    "ten", "eleven", "twelve", "thir" };
            //string teen = "teen";
            //string ty = "ty";
            //if(randomIntegerNumber < 13)
            //{
            //    Console.WriteLine($"{randomIntegerNumber} {numbers[randomIntegerNumber]}");
            //}
            //else if (randomIntegerNumber > 12 && randomIntegerNumber < 20)
            //{
            //    // LDY: фигурные скобки на курсе писать обязательно
            //    if (randomIntegerNumber == 13)
            //        Console.WriteLine($"{randomIntegerNumber} {numbers[randomIntegerNumber]}{teen}");
            //    else
            //        Console.WriteLine($"{randomIntegerNumber} {numbers[randomIntegerNumber/10]}{teen}");
            //}
            //else if (randomIntegerNumber > 20)
            //{
            //    // LDY: фигурные скобки на курсе писать обязательно
            //    if (randomIntegerNumber>49 && randomIntegerNumber < 60)
            //        Console.WriteLine($"{randomIntegerNumber} fif{ty} " +
            //        $"{numbers[randomIntegerNumber % 10]}");
            //    else
            //        Console.WriteLine($"{randomIntegerNumber} {numbers[randomIntegerNumber/10]}{ty} " +
            //        $"{numbers[randomIntegerNumber%10]}");
            //}
            //else
            //{
            //    Console.WriteLine($"{randomIntegerNumber} twenty");
            //}

            Console.WriteLine("___________________________________");
            Console.WriteLine("TASK16\n");
            int firstArrayCount = randomizer.Next(1, 20);
            int secondArrayCount = randomizer.Next(1, 20);
            int[] firstArray = new int[firstArrayCount];
            int[] secondArray = new int[secondArrayCount];
            for(int i = 0; i < firstArrayCount; i++)
            {
                firstArray[i] = randomizer.Next(-20, 20);
            }
            for (int i = 0; i < secondArrayCount; i++)
            {
                secondArray[i] = randomizer.Next(-20, 20);
            }
            int resultArrayCount = firstArrayCount > secondArrayCount ? firstArrayCount : secondArrayCount;
            int[] resultArray = new int[resultArrayCount];
            for (int i = 0; i < resultArrayCount; i++)
            {
                if (i >= firstArrayCount)
                {
                    resultArray[i] = secondArray[i];
                }
                else if (i >= secondArrayCount)
                {
                    resultArray[i] = firstArray[i];
                }
                else
                {
                    resultArray[i] = firstArray[i] > secondArray[i] ? firstArray[i] : secondArray[i];
                }
            }
            Console.WriteLine($"First array:");
            for (int i = 0; i < firstArrayCount; i++)
            {
               Console.Write($"{ firstArray[i]} ");
            }
            Console.WriteLine($"\nSecond array:");
            for (int i = 0; i < secondArrayCount; i++)
            {
                Console.Write($"{ secondArray[i]} ");
            }

            Console.WriteLine($"\nResult array:");
            for (int i = 0; i < resultArrayCount; i++)
            {
                Console.Write($"{ resultArray[i]} ");
            }


            Console.WriteLine("\n___________________________________");

            Console.Read();

        }
    }
}
