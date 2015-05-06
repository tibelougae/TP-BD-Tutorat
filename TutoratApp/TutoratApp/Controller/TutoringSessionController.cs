using DataLayer;
using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratApp.View;
using TutoratApp.ViewModel;

namespace TutoratApp.Controller
{
    public class TutoringSessionController
    {
        private readonly IEntityRepository<TutoringSession> tutoringSessionsRepository;
        private TutoringSessionListVM tutoringSessionList;
        private TutoringSessionListView view;

        private WorkingHoursTutorListVM workingHoursList;
        private WorkingHoursTutorListView workingHoursView;

        private TutoringSessionListVM tutoringSessionListPlanned;
        private TutoringSessionListView viewPlanned;

        private TutoringSessionListVM helpedStudentWithoutTutoringList;
        private TutoringSessionListView helpedStudentWithoutTutoringView;

        public TutoringSessionController(IEntityRepository<TutoringSession> _repo)
        {
            tutoringSessionsRepository = _repo;
            tutoringSessionList = new TutoringSessionListVM();
            workingHoursList = new WorkingHoursTutorListVM();
            tutoringSessionListPlanned = new TutoringSessionListVM();
            helpedStudentWithoutTutoringList = new TutoringSessionListVM();
        }
        public void showAllTutoringSessions(EfEntityRepository<HelpedStudent> helpedStudents, EfEntityRepository<Tutor> tutors)
        {
            IQueryable<TutoringSession> tutoringSessions = tutoringSessionsRepository.GetAll();
            tutoringSessionList.Clear();

            foreach (TutoringSession tutoringSession in tutoringSessions)
            {
                tutoringSessionList.Add(tutoringSession);
            }

            view = new TutoringSessionListView(tutoringSessionList);
           // view.showToScreen(helpedStudents, tutors);
        }

        public void showAllTutoringSessionsWithHours(EfEntityRepository<Tutor> tutors)
        {
            IQueryable<TutoringSession> tutoringSessions = tutoringSessionsRepository.GetAll();
            workingHoursList.Clear();

            foreach (TutoringSession tutoringSession in tutoringSessions)
            {
                workingHoursList.Add(tutors.GetById(tutoringSession.TutorID), tutoringSession.LengthSession);
            }


            workingHoursView = new WorkingHoursTutorListView(workingHoursList);
            workingHoursView.showToScreen();
        }

        public void showAllTutoringSessionsWithHoursPlanned(EfEntityRepository<HelpedStudent> helpedStudents, EfEntityRepository<Tutor> tutors)
        {
            IQueryable<TutoringSession> tutoringSessions = tutoringSessionsRepository.GetAll();
            tutoringSessionListPlanned.Clear();

            foreach (TutoringSession tutoringSession in tutoringSessions)
            {
                if(tutoringSession.DateSession > System.DateTime.Now)
                {
                    tutoringSessionList.Add(tutoringSession);
                }
            }
            viewPlanned = new TutoringSessionListView(tutoringSessionList);
           
        }

        public void showAllHelpedStudentsWithoutTutoring(EfEntityRepository<HelpedStudent> helpedStudents, EfEntityRepository<Tutor> tutors)
        {
            IQueryable<TutoringSession> tutoringSessions = tutoringSessionsRepository.GetAll();
            helpedStudentWithoutTutoringList.Clear();

            foreach (TutoringSession tutoringSession in tutoringSessions)
            {
                helpedStudentWithoutTutoringList.Add(tutoringSession);
            }
            helpedStudentWithoutTutoringView = new TutoringSessionListView(tutoringSessionList);
            
        }
    }
}
