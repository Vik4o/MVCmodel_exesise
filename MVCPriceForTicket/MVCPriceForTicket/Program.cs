namespace MVCPriceForTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportController controller = new TransportController();
            controller.Run();
        }
    }
}
