using System;
using System.Collections.Generic;
using System.Text;

namespace Math2ndGrade
{
    class AppViewModel
    {
        public List<string> ExercisesTypes { get; set; }        

        public AppViewModel()
        {
            ExercisesTypes = ExerGeneratorFactory.GetInstance().GetAllTypes();
        }
    }
}
