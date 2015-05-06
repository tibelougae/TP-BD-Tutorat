using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace TutoratApp.ViewModel
{
    public class HelpedStudentListVM
    {
         private List<HelpedStudent> helpedStudents = new List<HelpedStudent>();

        public void Add(HelpedStudent helpedStudent)
        {
            helpedStudents.Add(helpedStudent);
        }

        public void Clear()
        {
            helpedStudents.Clear();
        }

        public void showHelpedStudent()
        {
            foreach (HelpedStudent helpStudent in helpedStudents)
            {
                Console.WriteLine(helpStudent.LastName + ", "
                        + helpStudent.FirstName + ", "
                        + helpStudent.EmailAdress);
            }
        }
    }
}
