using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public interface IExerciseService
    {
        void AddExercise(string name, int calories);
        List<Exercise> GetAllExercises();
        Exercise GetMaxCaloriesExercise();
        int GetTotalCalories();
    }
}
