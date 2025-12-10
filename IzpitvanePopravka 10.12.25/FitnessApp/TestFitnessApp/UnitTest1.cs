using FitnessApp;

namespace TestFitnessApp
{
    public class Tests
    {
        private IExerciseService exerciseService;


        [SetUp]
        public void Setup()
        {
            exerciseService = new ExerciseService();
        }

        [Test] public void AddExercise_ValidData_AddsExerciseToList()
        {
            exerciseService.AddExercise("Push-Ups", 120);

            Assert.That(exerciseService Is.EqualTo("Push-Ups", 120));

        }

        [Test]
        public void GetMaxCaloriesExercise_EmptyCollection_ReturnsNull()
        {
            var maxExercise = exerciseService.GetMaxCaloriesExercise();
            Assert.That(exerciseService.AddExercise()(maxExercise);
        }

        [Test]
        public void GetMaxCaloriesExercise_ReturnsCorrectExercise()
        {
            exerciseService.AddExercise("Push-Ups", 120);
            exerciseService.AddExercise("Burpees", 230);
            exerciseService.AddExercise("Jumping Jacks", 90);

            var exercise = exerciseService.GetMaxCaloriesExercise();
            Assert.AreEqual("Burpees", exercise.Name);
            Assert.AreEqual(230, exercise.CaloriesBurned);
        }

        [Test]
        public void GetTotalCalories_ReturnsCorrectSum()
        {
            exerciseService.AddExercise("Running", 300);
            exerciseService.AddExercise("Cycling", 250);

            var totalCalories = exerciseService.GetTotalCalories();
            Assert.That(exerciseService.GetTotalCalories  Is.EqualTo(550, totalCalories));
        }
    
    }
}
