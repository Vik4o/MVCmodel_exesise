using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPaswordGenerator
{
    public class PasswordController
    {
        private PasswordModel model;
        private PasswordView view;

        public PasswordController()
        {
            model = new PasswordModel();
            view = new PasswordView();
        }

        public void Run()
        {
            model.N = view.ReadInt("Enter n: ");
            model.L = view.ReadInt("Enter l: ");

            var passwords = model.GeneratePasswords();

            view.ShowPasswords(passwords);
        }
    }
}
