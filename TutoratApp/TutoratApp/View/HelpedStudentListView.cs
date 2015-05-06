using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using TutoratApp.ViewModel;

namespace TutoratApp.View
{
    public class HelpedStudentListView
    {
        private HelpedStudentListVM helpedStudentList;

        public HelpedStudentListView(HelpedStudentListVM helpedStudentList)
        {
            this.helpedStudentList = helpedStudentList;
        }

        public void showToScreen()
        {
            foreach (HelpedStudent student in helpedStudentList.GetAll())
            {
               Console.WriteLine("Aidé : " + student.LastName + ", " + student.FirstName + ", " + student.EmailAdress);
            }
        }
    }
}
