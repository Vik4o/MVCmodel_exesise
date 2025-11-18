using System;
using System.Collections.Generic;
using System.Text;

namespace MagicNumberMVC
{
    public class MagicNumberModel
    {
        public int MagicNumber { get; set; }
        public List<string> Results { get; set; } = new List<string>();

        public void GenerateMagicNumbers()
        {
            Results.Clear();

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            for (int e = 1; e <= 9; e++)
                            {
                                for (int f = 1; f <= 9; f++)
                                {
                                    int product = a * b * c * d * e * f;

                                    if (product == MagicNumber)
                                    {
                                        string number = $"{a}{b}{c}{d}{e}{f}";
                                        Results.Add(number);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
