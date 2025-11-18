using System;
using System.Collections.Generic;
using System.Text;

namespace TilesMVC
{
    public class TilesController
    {
        private readonly ConsoleView view;
        private readonly TilesModel model;

        public TilesController()
        {
            view = new ConsoleView();
            model = new TilesModel();
        }

        public void Run()
        {
            model.N = view.ReadDouble("N (площадка): ");
            model.W = view.ReadDouble("W (ширина на плочка): ");
            model.L = view.ReadDouble("L (дължина на плочка): ");
            model.M = view.ReadDouble("M (ширина на пейка): ");
            model.O = view.ReadDouble("O (дължина на пейка): ");

            model.Calculate();

            view.PrintResult(model.NeededTiles, model.TotalTime);
        }
    }
}
