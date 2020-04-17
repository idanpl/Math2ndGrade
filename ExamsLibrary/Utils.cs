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

        public static string Print4ExercisesVertically(List<Tuple<int, int>> exers, char operation, int maxNumber)
        {
            if (exers.Count != 4)
            {
                return String.Empty;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"  ");
            sb.Append(WriteSingleNumberVertically(exers[0].Item1, maxNumber));
            sb.Append(WriteSingleNumberVertically(exers[1].Item1, maxNumber));
            sb.Append(WriteSingleNumberVertically(exers[2].Item1, maxNumber));
            sb.Append(WriteSingleNumberVertically(exers[3].Item1, maxNumber));
            sb.Append("\n");
            sb.Append($"{operation}                               {operation}                               {operation}                               {operation}");
            sb.Append("\n");
            sb.Append($"  ");
            sb.Append(WriteSingleNumberVertically(exers[0].Item2, maxNumber));
            sb.Append(WriteSingleNumberVertically(exers[1].Item2, maxNumber));
            sb.Append(WriteSingleNumberVertically(exers[2].Item2, maxNumber));
            sb.Append(WriteSingleNumberVertically(exers[3].Item2, maxNumber));
            sb.Append("\n");
            sb.Append("=====                    =====                     =====                     =====");
            sb.Append("\n\n\n");

            return sb.ToString();
        }

        private static string WriteSingleNumberVertically(int num, int maxNumber)
        {
            string result = $"{num}                          ";
            for (int i = 0; i < GetNumberLength(maxNumber) - GetNumberLength(num); ++i)
            {
                result += ($"  ");
            }
            return result;
        }

        private static int GetNumberLength(int number)
        {
            return number.ToString().Length;
        }
    }
}
