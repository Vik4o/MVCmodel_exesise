using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class ConsoleExerciseView
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("Fitness App");
            Console.WriteLine("1. Add Exercise");
            Console.WriteLine("2. List Exercises");
            Console.WriteLine("3. Max Calories Exercise");
            Console.WriteLine("4. Exit");
        }

        public void ShowExerciseList(List<Exercise> exercises)
        {
            foreach (var exercise in exercises)
            {
                Console.WriteLine($"{exercise.Name} burned {exercise.CaloriesBurned} kcal");
            }
        }

        public void ShowMaxCaloriesExercise(Exercise exercise)
        {
            if (exercise != null)
            {
                Console.WriteLine($"Max calories: {exercise.Name} -> {exercise.CaloriesBurned}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    }
}
