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
        List<HelpedStudent> studentList = new List<HelpedStudent>();
 
        public void Add(HelpedStudent student)
        {
            studentList.Add(student);
        }

        public void Clear()
        {
            studentList.Clear();
        }

        public IEnumerable<HelpedStudent> GetAll()
        {
            return studentList.AsEnumerable<HelpedStudent>();
        }
    }
}
