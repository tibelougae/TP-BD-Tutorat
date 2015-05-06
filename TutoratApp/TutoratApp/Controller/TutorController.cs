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
        private TutorListView view;

        public TutorController(IEntityRepository<Tutor> _repo)
        {
            tutorsRepository = _repo;
            tutorList = new TutorListVM();
        }
        public void showAllTutors()
        {
            IQueryable<Tutor> tutors = tutorsRepository.GetAll();
            tutorList.Clear();

            foreach (Tutor tutor in tutors)
            {
                tutorList.Add(tutor);
            }

            view = new TutorListView(tutorList);
            view.showTutors();
        }

        
    }
}
