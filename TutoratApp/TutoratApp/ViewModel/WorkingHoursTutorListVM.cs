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

        public void showWorkingHours()
        {
            foreach (var tutor in totalHours)
            {
                Console.WriteLine(tutor.Key.LastName + ", "
                        + tutor.Key.FirstName + ", "
                        + tutor.Key.EmailAdress + ", "
                        + tutor.Value);
            }
        }

        public void Clear()
        {
            totalHours.Clear();
        }
    }
}
