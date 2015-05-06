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
        List<TutoringSession> sessionList = new List<TutoringSession>();

        public void Add(TutoringSession session)
        {
            sessionList.Add(session);
        }

        public void Clear()
        {
            sessionList.Clear();
        }

        public IEnumerable<TutoringSession> GetAll()
        {
            return sessionList.AsEnumerable<TutoringSession>();
        }
    }
}
