using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HistogramController controller = new HistogramController();
            controller.Run();
        }
    }
}
