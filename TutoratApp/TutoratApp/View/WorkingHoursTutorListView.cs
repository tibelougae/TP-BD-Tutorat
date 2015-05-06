using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutoratApp.ViewModel;

namespace TutoratApp.Controller
{
    class WorkingHoursTutorListView
    {
        private WorkingHoursTutorListVM workingHoursList;

        public WorkingHoursTutorListView(WorkingHoursTutorListVM workingHoursList)
        {
            
            this.workingHoursList = workingHoursList;
        }

        public void showToScreen()
        {
            foreach (Tutor tutor in workingHoursList.GetAll())
            {
                Console.WriteLine(tutor.ToString());
            }
        }
    }
}
