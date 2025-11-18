using System;
using System.Collections.Generic;
using System.Text;

namespace DivisoinMVC
{
    public class DivisionController
    {
        private readonly ConsoleView view;
        private readonly DivisionModel model;

        public DivisionController()
        {
            view = new ConsoleView();
            model = new DivisionModel();
        }

        public void Run()
        {
            model.N = view.ReadInt("Въведи брой числа: ");

            for (int i = 0; i < model.N; i++)
            {
                int number = view.ReadInt($"Число {i + 1}: ");
                model.Numbers.Add(number);
            }

            model.Calculate();

            view.PrintPercent(model.P1);
            view.PrintPercent(model.P2);
            view.PrintPercent(model.P3);
        }
    }
}
