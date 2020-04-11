using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    class MultiplactionUntil100
    {
        internal void GenerateExercises(int excersicesNum)
        {
            GenerateExcercises(1, 9, 1, 9, excersicesNum);
        }

        private void GenerateExcercises(int FirstMulInitialNum, int FirstMulRange, int secondMulInitialNum, int secondMulRange, int excercisesNum)
        {
            for (int i = 1; i <= excercisesNum / 3; ++i)
            {
                    int firstNum = new Random().Next(FirstMulInitialNum, FirstMulInitialNum + FirstMulRange + 1);
                    int secondNum = new Random().Next(secondMulInitialNum, secondMulInitialNum + secondMulRange + 1);
                    string exercise = $"{firstNum}*{secondNum} =";
                    Console.Write($"{exercise}                                ");
                    if (firstNum != 10)
                    {
                        Console.Write($" ");
                    }
                    if (secondNum != 10)
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
