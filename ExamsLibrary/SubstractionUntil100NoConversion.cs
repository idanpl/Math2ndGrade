using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    internal class SubstractionUntil100NoConversion : IExercise
    {
        public string GenerateExercises(int exercisesNumber)
        {
            return GenerateExcercises(20,100, exercisesNumber);
        }

        private string GenerateExcercises(int minimumNum, int maximumNum, int exercisesNumber)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= exercisesNumber; ++i)
            {
                int subtrahend = new Random().Next(minimumNum, maximumNum + 1);
                int minx0 = new Random().Next(0, subtrahend % 10 + 1);
                int minx1 = new Random().Next(0, subtrahend / 10 + 1);
                int minuend = minx1 * 10 + minx0;
                sb.Append(Utils.PrintExercise(subtrahend, minuend, '-', 100));
                if (i % 3 == 0)
                {
                    sb.Append("\n");
                }
            }

            return sb.ToString();
        }
    }
}
