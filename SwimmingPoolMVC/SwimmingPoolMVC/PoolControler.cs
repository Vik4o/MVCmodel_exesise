using System;
using System.Collections.Generic;
using System.Text;

namespace SwimmingPoolMVC
{
    public class PoolController
    {
        private readonly ConsoleView view;
        private readonly PoolModel model;

        public PoolController()
        {
            view = new ConsoleView();
            model = new PoolModel();
        }

        public void Run()
        {
            model.V = view.ReadInt("Обем на басейна (V): ");
            model.P1 = view.ReadInt("Дебит тръба 1 (P1): ");
            model.P2 = view.ReadInt("Дебит тръба 2 (P2): ");
            model.H = view.ReadDouble("Часове отсъствие (H): ");

            string result = model.CalculateState();
            view.Print(result);
        }
    }
}
