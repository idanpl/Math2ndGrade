using System;
using System.Collections.Generic;

namespace Math2ndGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> exercisesTypeKeys = ExerGeneratorFactory.GetInstance().GetAllTypes();
            var firstType = ExerGeneratorFactory.GetInstance().GetExerciseGenerator(exercisesTypeKeys[0]);
            Console.WriteLine(firstType.GenerateExercises(60));
            //SubstractionUntil100NoConversion sub = new SubstractionUntil100NoConversion();
            //sub.GenerateExercises(72);
            //SubtractionUntil20 subtractionUntil20 = new SubtractionUntil20();
            // subtractionUntil20.GenerateExercises(60);


            //            MultiplactionUntil100 multiplactionUntil100 = new MultiplactionUntil100();
            //            multiplactionUntil100.GenerateExercises(120);
        }
    }
}
