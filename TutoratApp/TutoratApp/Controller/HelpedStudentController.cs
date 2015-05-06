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

        public HelpedStudentController(IEntityRepository<HelpedStudent> _repo)
        {
            helpedStudentsRepository = _repo;
            helpedStudentList = new HelpedStudentListVM();
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
    }
}
