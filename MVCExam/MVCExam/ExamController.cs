using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExam
{
    public class ExamController
    {
        private ExamView view;
        private ExamModel model;

        public ExamController()
        {
            view = new ExamView();
            model = new ExamModel();
        }

        public void Run()
        {
            model.ExamHour = view.ReadNumber("Exam hour: ");
            model.ExamMinute = view.ReadNumber("Exam minute: ");
            model.ArrivalHour = view.ReadNumber("Arrival hour: ");
            model.ArrivalMinute = view.ReadNumber("Arrival minute: ");

            string status = model.GetStatus();
            view.ShowStatus(status);

            string details = model.GetDetailedMessage();
            view.ShowDetails(details);
        }
    }
}
