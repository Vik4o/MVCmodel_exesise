namespace SwimmingPoolMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new PoolController();
            controller.Run();
        }
    }
}
