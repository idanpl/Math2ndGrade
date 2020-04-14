using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    public class ExerGeneratorFactory
    {
        Dictionary<string, IExercise> exercisesRegistry = new Dictionary<string, IExercise>();
        private static ExerGeneratorFactory exerGeneratorFactory = new ExerGeneratorFactory();
        public static ExerGeneratorFactory GetInstance()
        {
            return exerGeneratorFactory;
        }

        private ExerGeneratorFactory()
        {
            exercisesRegistry.Add("Substraction Until 20", new SubtractionUntil20());
            exercisesRegistry.Add("Substract until 100 no conversion", new SubstractionUntil100NoConversion());
            exercisesRegistry.Add("Multiplication until 100", new MultiplactionUntil100());
            
        }

        public IExercise GetExerciseGenerator(string key)
        {
            if (exercisesRegistry.ContainsKey(key))
            {
                return exercisesRegistry[key];
            }

            return null;
        }

        public List<string> GetAllTypes()
        {
            return new List<string>(exercisesRegistry.Keys);
        }

    }
}
