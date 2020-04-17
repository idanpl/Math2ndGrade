using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    class SubtractionUntil100WithConvertion : IExercise
    {
        public string GenerateExercises(int exercisesNumber)
        {
            return GenerateExcercises(20, 100, exercisesNumber);
        }

        private string GenerateExcercises(int minimumNum, int maximumNum, int exercisesNumber)
        {
            
            
            List<Tuple<int, int>> results = new List<Tuple<int, int>>();
            for (int i = 1; i <= exercisesNumber; ++i)
            {
                results.Add(GenerateExercise(minimumNum, maximumNum));
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < results.Count/4; ++i)
            {
                List<Tuple<int, int>> fourTuples = new List<Tuple<int, int>>();
                fourTuples.Add(results[i * 3]);
                fourTuples.Add(results[i * 3 + 1]);
                fourTuples.Add(results[i * 3 + 2]);
                fourTuples.Add(results[i * 3 + 3]);
                sb.Append(Utils.Print4ExercisesVertically(fourTuples, '-', 100));
            }
            //sb.Append(Utils.PrintExercise(result.Item1, result.Item2, '-', 100));
            //if (i % 3 == 0)
            //{
            //    sb.Append("\n");
            //}


            return sb.ToString();
        }

        private Tuple<int, int> GenerateExercise(int minimumNum, int maximumNum)
        {
            int subtrahend;
            while (true)
            {
                subtrahend = new Random().Next(minimumNum, maximumNum + 1);
                if (subtrahend % 10 != 9) break;
            }
            int minx0 = new Random().Next(subtrahend % 10 + 1, 10);
            int minx1 = new Random().Next(0, subtrahend / 10);
            
            int minuend = minx1 * 10 + minx0;
            return new Tuple<int, int> (subtrahend, minuend);
            
        }



    }
}
