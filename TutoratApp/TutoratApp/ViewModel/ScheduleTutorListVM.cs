using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratApp.ViewModel
{
    public class ScheduleTutorListVM
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

        public IEnumerable<Tutor> GetAll()
        {
            return tutors.AsEnumerable<Tutor>();
        }
    }
}
