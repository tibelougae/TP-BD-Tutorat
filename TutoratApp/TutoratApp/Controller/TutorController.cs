using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratApp.ViewModel;
using DataLayer;
using DataLayer.Model;
using DataLayer.EfEntityFramework;
using TutoratApp.View;

namespace TutoratApp.Controller
{
    public class TutorController
    {
        private readonly IEntityRepository<Tutor> tutorsRepository;
        private TutorListVM tutorList;
        private TutorListView tutorView;

        private WorkingHoursTutorListVM workingHoursList;
        private WorkingHoursTutorListView workingHoursView;

        private TutorListVM tutorListPlanned;
        private TutorListView tutorViewPlanned;

        private TutorListVM tutorListDate;
        private TutorListView tutorViewDate;

        public TutorController(IEntityRepository<Tutor> _repo)
        {
            tutorsRepository = _repo;
            tutorList = new TutorListVM();
            workingHoursList = new WorkingHoursTutorListVM();
            tutorListPlanned = new TutorListVM();
            tutorListDate = new TutorListVM();
        }
        public void showAllTutors()
        {
            IQueryable<Tutor> tutors = tutorsRepository.GetAll();
            tutorList.Clear();

            foreach (Tutor tutor in tutors)
            {
                tutorList.Add(tutor);
            }

            tutorView = new TutorListView(tutorList);
            tutorView.showToScreen();
        }

        public void showAllTutoringSessionsWithHours()
        {
            IQueryable<Tutor> tutors = tutorsRepository.GetAll();
            workingHoursList.Clear();

            foreach (Tutor tutor in tutors)
            {
                foreach (TutoringSession session in tutor.Sessions)
                {
                    workingHoursList.Add(tutor, session.LengthSession);
                }
            }


            workingHoursView = new WorkingHoursTutorListView(workingHoursList);
            workingHoursView.showToScreen();
        }

        public void showAllTutoringSessionsWithHoursPlanned()
        {
            IQueryable<Tutor> tutors = tutorsRepository.GetAll();
            tutorListPlanned.Clear();

            foreach (Tutor tutor in tutors)
            {
                foreach (TutoringSession session in tutor.Sessions)
                {
                    if (session.DateSession > System.DateTime.Now)
                    {
                        tutorListPlanned.Add(tutor);
                    }
                }
            }
            tutorViewPlanned = new TutorListView(tutorListPlanned);
            tutorViewPlanned.showToScreen();
        }

        public void showAllTutorsWithoutSessionAt(DateTime date)
        {
            IQueryable<Tutor> tutors = tutorsRepository.GetAll();
            tutorListDate.Clear();

            foreach (Tutor tutor in tutors)
            {
                bool sessionFound = false;
                foreach (TutoringSession session in tutor.Sessions)
                {
                    if (session.DateSession.Date == date)
                    {
                        sessionFound = true;
                    }
                }

                if (!sessionFound)
                {
                    tutorListDate.Add(tutor);
                }
            }

            tutorViewDate = new TutorListView(tutorListDate);
            tutorViewDate.showToScreen();
        }
    }
}
