using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutoratApp.Controller
{
    class WorkingHoursTutorListView
    {
        private ViewModel.WorkingHoursTutorListVM workingHoursList;

        public WorkingHoursTutorListView(ViewModel.WorkingHoursTutorListVM workingHoursList)
        {
            
            this.workingHoursList = workingHoursList;
        }

        internal void showToScreen()
        {
            workingHoursList.showWorkingHours();
        }
    }
}
