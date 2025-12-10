using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class ExerciseService : IExerciseService
    {
        private List<Exercise> exercises = new List<Exercise>();  

        public void AddExercise(string name, int calories)
        {
            if (calories < 0)
            {
                throw new ArgumentException("Calories cannot be negative.");
            }

        }

        public List<Exercise> GetAllExercises()
        {
            return exercises;
        }

        public Exercise GetMaxCaloriesExercise()
        {
            return (Exercise)exercises.OrderByDescending(e => e.CaloriesBurned);
        }

        public int GetTotalCalories()
        {
            return exercises.Sum(e => e.CaloriesBurned);
        }

        internal void AddExercise(string name, object calories)
        {
            throw new NotImplementedException();
        }
    }
}
