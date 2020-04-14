using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    internal class SubtractionUntil20 : IExercise
    {
        public string GenerateExercises(int excersicesNum)
        {
            return(GenerateExcercises(10, 5, 5, 4, excersicesNum));
        }

        private string GenerateExcercises(int subtrahendFirstNun, int subtrahendRange, int minuendFirstNum, int minuendRange, int excercisesNum)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= excercisesNum; ++i)
            {
                int subtrahend = new Random().Next(subtrahendFirstNun, subtrahendFirstNun + subtrahendRange + 1);
                int minuend = new Random().Next(minuendFirstNum, minuendFirstNum + minuendRange + 1);
                sb.Append(Utils.PrintExercise(subtrahend, minuend, '-', subtrahendFirstNun + subtrahendRange + subtrahendFirstNun));
                if (i % 3 == 0)
                {
                    sb.Append("\n");
                }
            }
            return sb.ToString();
        }
    }
}
