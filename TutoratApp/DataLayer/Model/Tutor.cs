using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace DataLayer.Model
{
    class Tutor : Entity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAdress { get; set; }

    }
}
