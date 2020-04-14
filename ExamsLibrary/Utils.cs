using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    class Utils
    {
        public static string PrintExercise(int firstNum, int secondNum, char operation, int maxNumber)
        {
            StringBuilder sb = new StringBuilder();
            string exercise = $"{firstNum}{operation}{secondNum}=";
            sb.Append($"{exercise}                          ");
            int numbersLength = GetNumberLength(firstNum) + GetNumberLength(secondNum);
            for (int i = 0; i < GetNumberLength(maxNumber) * 2 - numbersLength; ++i)
            {
                sb.Append($"  ");
            }
            return sb.ToString();
        }

        private static int GetNumberLength(int number)
        {
            return number.ToString().Length;
        }
    }
}
