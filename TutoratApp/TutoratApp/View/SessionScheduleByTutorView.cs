using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratApp.ViewModel;

namespace TutoratApp.View
{
    public class SessionScheduleByTutorView
    {
        private ScheduleTutorListVM tutorList;

        public SessionScheduleByTutorView(ScheduleTutorListVM tutorList)
        {
            
            this.tutorList = tutorList;
        }

        public void showToScreen()
        {
            foreach (Tutor tutor in tutorList.GetAll())
            {
                Console.WriteLine("Tuteur : " + tutor.LastName + ", " + tutor.FirstName);
                foreach (TutoringSession session in tutor.Sessions)
                {
                    Console.WriteLine("     Rencontre : " + session.DateSession + ", " + session.Helped.LastName + ", " + session.Helped.FirstName);
                }
            }
        }
    }
}
