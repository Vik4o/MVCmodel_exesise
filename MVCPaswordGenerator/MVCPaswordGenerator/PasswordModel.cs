using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPaswordGenerator
{
    public class PasswordModel
    {
        public int N { get; set; }
        public int L { get; set; }

        public List<string> GeneratePasswords()
        {
            List<string> result = new List<string>();

            for (int d1 = 1; d1 <= N; d1++)
            {
                for (int d2 = 1; d2 <= N; d2++)
                {
                    for (char c1 = 'a'; c1 < 'a' + L; c1++)
                    {
                        for (char c2 = 'a'; c2 < 'a' + L; c2++)
                        {
                            for (int d3 = 1; d3 <= N; d3++)
                            {
                                if (d3 > d1 && d3 > d2)
                                {
                                    string pass = $"{d1}{d2}{c1}{c2}{d3}";
                                    result.Add(pass);
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
