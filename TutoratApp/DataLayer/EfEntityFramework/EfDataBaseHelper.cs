using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfEntityFramework
{
    class EfDataBaseHelper
    {
        EfEntityRepository<HelpedStudent> HelpedStudents;
        EfEntityRepository<Tutor> Tutors;
        EfEntityRepository<TutoringSession> TutoringSessions;


        public void SeedDataBase()
        {
            //Tutors
            Tutors.Add(new Tutor()
                {
                    LastName = "Bilodeau",
                    FirstName = "Gary",
                    EmailAdress = "bgary2@hotmail.com"
                });

            Tutors.Add(new Tutor()
            {
                LastName = "Gagnon",
                FirstName = "Samuel",
                EmailAdress = "samPP92@hotmail.com"
            });

            Tutors.Add(new Tutor()
            {
                LastName = "Gingras",
                FirstName = "Simon",
                EmailAdress = "ptitguy22@bell.net"
            });

            Tutors.Add(new Tutor()
            {
                LastName = "Roy",
                FirstName = "Eric",
                EmailAdress = "eroy231@videotron.ca"
            });

            Tutors.Add(new Tutor()
            {
                LastName = "Veilleux",
                FirstName = "Caroline",
                EmailAdress = "caro.koko@hotmail.com"
            });

            Tutors.Add(new Tutor()
            {
                LastName = "Tremblay",
                FirstName = "Karine",
                EmailAdress = "kar.tremblay@gmail.com"
            });

            Tutors.Add(new Tutor()
            {
                LastName = "Vézina",
                FirstName = "Louis",
                EmailAdress = "vl410Bd@gmail.com"
            });

            //Helped Students
            HelpedStudents.Add(new HelpedStudent()
                {
                    LastName = "Arsenault",
                    FirstName = "Marc",
                    EmailAdress = "marco.arso@hotmail.com"
                });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Boilard",
                FirstName = "Éric",
                EmailAdress = "eric.r.boilard@coop.com"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Couture",
                FirstName = "Jean-Cristophe",
                EmailAdress = "jc.couture.wilde@hotmail.com"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Desrosiers",
                FirstName = "Julianne",
                EmailAdress = "galypo13@hotmail.com"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Arsenault",
                FirstName = "Marc",
                EmailAdress = "marco.arso@hotmail.com"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Grégoire-Allen",
                FirstName = "Léo",
                EmailAdress = "leoga@hotmail.com"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Hamel",
                FirstName = "François"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Lepage",
                FirstName = "Jérémy"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Poitras",
                FirstName = "Nicolas"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Roy-Gagnon",
                FirstName = "Samuel"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Simard",
                FirstName = "Benjamin"
            });

            HelpedStudents.Add(new HelpedStudent()
            {
                LastName = "Vachon",
                FirstName = "Samuel"
            });

            //Tutoring Sessions
            TutoringSessions.Add(new TutoringSession()
                { 
                    DateSession = new DateTime(16,03,2015,13,0,0),
                    LengthSession = 2,
                    HelpedID = HelpedStudents.GetById(5),
                    TutorID = Tutors.GetById(5)
                });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(24, 03, 2015, 10, 0, 0),
                LengthSession = 1,
                HelpedID = HelpedStudents.GetById(5),
                TutorID = Tutors.GetById(1)
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(24, 03, 2015, 10, 0, 0),
                LengthSession = 1,
                HelpedID = HelpedStudents.GetById(2),
                TutorID = Tutors.GetById(4)
            });

            //...

        }
    }
}
