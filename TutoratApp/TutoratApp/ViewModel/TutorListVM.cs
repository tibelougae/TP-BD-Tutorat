using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace TutoratApp.ViewModel
{
    class TutorListVM
    {
        public List<Tutor> tutors;

        public void showToScreen()
        {
            for (int i = 0; i < tutors.Count<Tutor>(); i++)
            {
                Console.WriteLine(tutors.ElementAt<Tutor>(i).LastName + ", "
                        + tutors.ElementAt<Tutor>(i).FirstName + ", "
                        + tutors.ElementAt<Tutor>(i).EmailAdress);
            }
        }
    }
}
