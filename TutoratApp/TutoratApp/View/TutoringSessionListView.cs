using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratApp.View;
using TutoratApp.ViewModel;

namespace TutoratApp.View
{
    public class TutoringSessionListView
    {
        private TutoringSessionListVM sessionList;

        public TutoringSessionListView(TutoringSessionListVM sessionList)
        {
            
            this.sessionList = sessionList;
        }

        public void showToScreen()
        {
            foreach (TutoringSession session in sessionList.GetAll())
            {
                Console.WriteLine("Session : " + session.DateSession + ", " + session.Tutor.LastName + ", " + session.Tutor.FirstName + " -- aide -- " + session.Helped.LastName + ", " + session.Helped.FirstName);
            }
        }
    }
}
