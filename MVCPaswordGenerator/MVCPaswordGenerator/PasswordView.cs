using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPaswordGenerator
{
    public class PasswordView
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void ShowPasswords(List<string> passwords)
        {
            Console.WriteLine(string.Join(" ", passwords));
        }
    }
}
