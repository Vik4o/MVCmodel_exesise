namespace izpitvane
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StudentService service = new StudentService();
    //        ConsoleStudentView view = new ConsoleStudentView();
    //        StudentController controller = new StudentController(service, view);

    //        controller.Run();

    //    }
    //}

    internal class Program
    {
        static List<string> students = new List<string>();
        static List<double> grade = new List<double>();

        static void Main(string[] args)
        {
            Console.WriteLine("student grade app");
            while (true)
            {
                Console.WriteLine("1 add");
                Console.WriteLine("2 list");
                Console.WriteLine("3 best");
                Console.WriteLine("4 exit");
                var x = Console.ReadLine();

                if (x == "1")
                {
                    Console.WriteLine("name:");
                    var quantity = Console.ReadLine();
                    Console.WriteLine("grade:");
                    var grades = double.Parse(Console.ReadLine());
                    students.Add(quantity);
                    grade.Add(grades);
                }
                else if (x == "2")
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine(students[i] + " -> " + grade[i]);
                    }
                }
                else if (x == "3")
                {
                    double max = -1;
                    string student = "";
                    for (int i = 0; i < grade.Count; i++)
                    {
                        if (grade[i] > max)
                        {
                            max = grade[i];
                            student = students[i];
                        }
                    }
                    Console.WriteLine("best: " + student + " " + max);
                }
                else if (x == "4")
                {
                    return;
                }
            }
        }
    }

}
