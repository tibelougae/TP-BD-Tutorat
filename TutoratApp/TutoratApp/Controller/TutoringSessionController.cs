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

        public TutoringSessionController(IEntityRepository<TutoringSession> _repo)
        {
            tutoringSessionsRepository = _repo;
            tutoringSessionList = new TutoringSessionListVM();
        }
        public void showAllTutoringSessions()
        {
            IQueryable<TutoringSession> tutoringSessions = tutoringSessionsRepository.GetAll();
            tutoringSessionList.Clear();

            foreach (TutoringSession tutoringSession in tutoringSessions)
            {
                tutoringSessionList.Add(tutoringSession);
            }

            view = new TutoringSessionListView(tutoringSessionList);
            view.showToScreen();
        }       
    }
}
