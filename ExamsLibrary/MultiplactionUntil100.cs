using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    class MultiplactionUntil100 : IExercise
    {
        public string GenerateExercises(int excersicesNum)
        {
            return (GenerateExcercises(1, 9, 1, 9, excersicesNum));
        }

        private string GenerateExcercises(int FirstMulInitialNum, int FirstMulRange, int secondMulInitialNum, int secondMulRange, int excercisesNum)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= excercisesNum / 3; ++i)
            {
                int firstNum = new Random().Next(FirstMulInitialNum, FirstMulInitialNum + FirstMulRange + 1);
                int secondNum = new Random().Next(secondMulInitialNum, secondMulInitialNum + secondMulRange + 1);
                sb.Append(Utils.PrintExercise(firstNum, secondNum, '*', 100));
                if (i % 3 == 0)
                {
                    sb.Append("\n");
                }
            }
            return sb.ToString();
        }
    }
}
