using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistogram
{
    public class HistogramController
    {
        private HistogramModel model;
        private HistogramView view;

        public HistogramController()
        {
            model = new HistogramModel();
            view = new HistogramView();
        }

        public void Run()
        {
            model.Count = view.ReadInt("Enter count N: ");

            for (int i = 0; i < model.Count; i++)
            {
                int number = view.ReadInt("");
                model.Numbers.Add(number);
            }

            double[] percentages = model.CalculatePercentages();

            view.ShowPercentages(percentages);
        }
    }
}
