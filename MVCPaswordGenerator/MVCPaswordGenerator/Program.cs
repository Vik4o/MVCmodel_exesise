using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPaswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordController controller = new PasswordController();
            controller.Run();
        }
    }
}
