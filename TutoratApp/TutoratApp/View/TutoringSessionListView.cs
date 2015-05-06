using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratApp.View;
using TutoratApp.ViewModel;

namespace TutoratApp.View
{
    public class TutoringSessionListView
    {
        private TutoringSessionListVM tutoringSessions;

        public TutoringSessionListView(TutoringSessionListVM _tutoringSession)
        {
            tutoringSessions = _tutoringSession;
        }
        public void showToScreen(EfEntityRepository<HelpedStudent> helpedStudents, EfEntityRepository<Tutor> tutors)
        {
            tutoringSessions.showTutoringSession(helpedStudents, tutors);
        }

        public void showPlannedToScreen(EfEntityRepository<HelpedStudent> helpedStudents, EfEntityRepository<Tutor> tutors)
        {
            tutoringSessions.showPlannedTutoringSessions(helpedStudents, tutors);
        }

        public void showStudentWithoutTutoring(EfEntityRepository<HelpedStudent> helpedStudents)
        {
            tutoringSessions.showStudentsWithoutTutoring(helpedStudents);
        }
    }
}
