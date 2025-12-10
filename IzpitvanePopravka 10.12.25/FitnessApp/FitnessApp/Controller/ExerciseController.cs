using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class ExerciseController
    {
        private IExerciseService exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            this.exerciseService = exerciseService;
        }


        public void AddExercise(string name, int calories)
        {
            exerciseService.AddExercise(name, calories);
        }

        public List<Exercise> GetAllExercises()
        {
            return exerciseService.GetAllExercises();
        }

        public Exercise GetMaxCaloriesExercise()
        {
            return exerciseService.GetMaxCaloriesExercise();
        }

        public int GetTotalCalories()
        {
            return exerciseService.GetTotalCalories();
        }
    }
}
