using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratApp.ViewModel
{
    public class TutoringSessionListVM
    {
        public DateTime DateTimeSession { get; set; }

        public string HelpedFirstName { get; set; }

        public string HelpedLastName { get; set; }

        public int Id { get; set; }

        public int LenghtSession { get; set; }

        public string TutorFirstName { get; set; }

        public string TutorLastName { get; set; }

        public string ToString()
        {
            return DateTimeSession.ToString() + ", " + LenghtSession + " heure(s), " + HelpedLastName + " " + HelpedFirstName;
        }
    }
}
