using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratApp.ViewModel;

namespace TutoratApp.View
{
    public class TutorListView
    {
        private TutorListVM tutors;

        public TutorListView(TutorListVM _tutors)
        {
            tutors = _tutors;
        }
        public void showTutors()
        {
            tutors.showToScreen();
        }
    }
}
