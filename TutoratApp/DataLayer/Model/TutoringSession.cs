using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class TutoringSession : Entity
    {
        public DateTime DateSession { get; set; }
        public int LengthSession { get; set; }

        //Foreign Keys
        public virtual int TutorID { get; set; }
        public virtual int HelpedID { get; set; }

        public virtual HelpedStudent Helped { get; set; }

        public virtual Tutor Tutor { get; set; }

    }
}
