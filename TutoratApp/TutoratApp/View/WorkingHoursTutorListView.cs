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
            foreach (KeyValuePair<Tutor,int> tutor in workingHoursList.GetAll())
            {
                Console.WriteLine("Tuteur : " + tutor.Key.LastName + ", " + tutor.Key.FirstName + ", " + tutor.Key.EmailAdress + ", " + tutor.Value);
            }
        }
    }
}
