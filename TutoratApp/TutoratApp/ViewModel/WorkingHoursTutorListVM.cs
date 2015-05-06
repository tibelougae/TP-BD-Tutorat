using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratApp.ViewModel
{
    public class WorkingHoursTutorListVM
    {
        public Dictionary<Tutor, int> totalHours = new Dictionary<Tutor,int>();

        public void Add(Tutor tutor, int hour)
        {
            if (!totalHours.ContainsKey(tutor))
            {
                totalHours[tutor] = 0;
            }

            totalHours[tutor] += hour;
        }

        public void Clear()
        {
            totalHours.Clear();
        }

        public Dictionary<Tutor, int> GetAll()
        {
            return totalHours;
        }
    }
}
