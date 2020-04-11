using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    class SubtractionUntil20
    {
        internal void GenerateExercises(int excersicesNum)
        {
            GenerateExcercises(10, 5, 5, 4, excersicesNum);
        }

        private void GenerateExcercises(int subtrahendFirstNun, int subtrahendRange, int minuendFirstNum, int minuendRange, int excercisesNum)
        {
            for (int i = 1; i <= excercisesNum; ++i)
            {
                    int subtrahend = new Random().Next(subtrahendFirstNun, subtrahendFirstNun+subtrahendRange+1);
                    int minuend = new Random().Next(minuendFirstNum, minuendFirstNum + minuendRange + 1);
                    string exercise = $"{subtrahend}-{minuend} =";
                    Console.Write($"{exercise}                                ");
                    if (minuend != 10)
                    {
                        Console.Write($" ");
                    }
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
