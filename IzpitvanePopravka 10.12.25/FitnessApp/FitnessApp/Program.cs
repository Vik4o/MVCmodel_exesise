using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var exerciseService = new ExerciseService();
            var exerciseController = new ExerciseController(exerciseService);
            var view = new ConsoleExerciseView();

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter exercise name:");
                string name = Console.ReadLine();
                int calories = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter calories burned:");
                exerciseService.AddExercise(name, calories);
           
            }
            else if (choice == "2")
            {
                var exercises = exerciseController.GetAllExercises();
                view.ShowExerciseList(exercises);
            }
            else if (choice == "3")
            {
                var maxExercise = exerciseController.GetMaxCaloriesExercise();
                view.ShowMaxCaloriesExercise(maxExercise);
            }
            else if (choice == "4")
            {
                return;
            }
        }

    }
    
}
