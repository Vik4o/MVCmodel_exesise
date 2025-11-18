using System;
using System.Collections.Generic;
using System.Text;

namespace MagicNumberMVC
{
    public class MagicNumberController
    {
        private readonly ConsoleView view;
        private readonly MagicNumberModel model;

        public MagicNumberController()
        {
            view = new ConsoleView();
            model = new MagicNumberModel();
        }

        public void Run()
        {
            model.MagicNumber = view.ReadInt("Въведи магическо число: ");
            model.GenerateMagicNumbers();
            view.PrintResults(model.Results);
        }
    }
}
