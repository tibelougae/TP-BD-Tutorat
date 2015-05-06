using DataLayer;
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
    public class HelpedStudentController
    {
        private readonly IEntityRepository<HelpedStudent> helpedStudentsRepository;
        private HelpedStudentListVM helpedStudentList;
        private HelpedStudentListView view;

        private HelpedStudentListVM helpedStudentWithoutTutoringList;
        private HelpedStudentListView helpedStudentWithoutTutoringView;

        public HelpedStudentController(IEntityRepository<HelpedStudent> _repo)
        {
            helpedStudentsRepository = _repo;
            helpedStudentList = new HelpedStudentListVM();
            helpedStudentWithoutTutoringList = new HelpedStudentListVM();
        }
        public void showAllHelpedStudents()
        {
            IQueryable<HelpedStudent> helpedStudents = helpedStudentsRepository.GetAll();
            helpedStudentList.Clear();

            foreach (HelpedStudent helpedStudent in helpedStudents)
            {
                helpedStudentList.Add(helpedStudent);
            }

            view = new HelpedStudentListView(helpedStudentList);
            view.showToScreen();
        }

        public void showAllHelpedStudentsWithoutTutoring()
        {
            IQueryable<HelpedStudent> helpedStudents = helpedStudentsRepository.GetAll();
            helpedStudentWithoutTutoringList.Clear();

            foreach (HelpedStudent helpedStudent in helpedStudents)
            {
                if ( helpedStudent.Sessions.Count() == 0)
                {
                    helpedStudentWithoutTutoringList.Add(helpedStudent);
                }
            }
            helpedStudentWithoutTutoringView = new HelpedStudentListView(helpedStudentWithoutTutoringList);
            helpedStudentWithoutTutoringView.showToScreen();
        }
    }
}
