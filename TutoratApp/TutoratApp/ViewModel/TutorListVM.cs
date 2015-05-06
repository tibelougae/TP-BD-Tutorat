using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace TutoratApp.ViewModel
{
    public class TutorListVM
    {
        private List<Tutor> tutors = new List<Tutor>();

        public void Add(Tutor tutor)
        {
            tutors.Add(tutor);
        }

        public void Clear()
        {
            tutors.Clear();
        }

        public void showToScreen()
        {
            foreach(Tutor tutor in tutors)
            {
                Console.WriteLine(tutor.LastName + ", "
                        + tutor.FirstName + ", "
                        + tutor.EmailAdress);
            }
        }
    }
}
