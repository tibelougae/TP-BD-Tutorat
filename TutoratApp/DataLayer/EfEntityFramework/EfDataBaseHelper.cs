using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfEntityFramework
{
    public class EfDataBaseHelper
    {
        private EfEntityRepository<HelpedStudent> HelpedStudents;
        private EfEntityRepository<Tutor> Tutors;
        private EfEntityRepository<TutoringSession> TutoringSessions;

        public EfDataBaseHelper()
        {
            HelpedStudents = new EfEntityRepository<HelpedStudent>();
            Tutors = new EfEntityRepository<Tutor>();
            TutoringSessions = new EfEntityRepository<TutoringSession>();
        }

        public void SeedDataBase()
        {
            HelpedStudents.DeleteAll();
            Tutors.DeleteAll();
            TutoringSessions.DeleteAll();

            //Tutors
            var tutor1 = new Tutor()
               {
                    LastName = "Bilodeau",
                    FirstName = "Gary",
                    EmailAdress = "bgary2@hotmail.com"
               };

            var tutor2 = new Tutor()
             {
                 LastName = "Gagnon",
                 FirstName = "Samuel",
                 EmailAdress = "samPP92@hotmail.com"
             };

            var tutor3 = new Tutor()
            {
                LastName = "Gingras",
                FirstName = "Simon",
                EmailAdress = "ptitguy22@bell.net"
            };

            var tutor4 = new Tutor()
            {
                LastName = "Roy",
                FirstName = "Eric",
                EmailAdress = "eroy231@videotron.ca"
            };

            var tutor5 = new Tutor()
            {
                LastName = "Veilleux",
                FirstName = "Caroline",
                EmailAdress = "caro.koko@hotmail.com"
            };

            var tutor6 = new Tutor()
            {
                LastName = "Tremblay",
                FirstName = "Karine",
                EmailAdress = "kar.tremblay@gmail.com"
            };

            var tutor7 = new Tutor()
            {
                LastName = "Vézina",
                FirstName = "Louis",
                EmailAdress = "vl410Bd@gmail.com"
            };

            Tutors.Add(tutor1);
            Tutors.Add(tutor2);
            Tutors.Add(tutor3);
            Tutors.Add(tutor4);
            Tutors.Add(tutor5);
            Tutors.Add(tutor6);
            Tutors.Add(tutor7);

            //Helped Students
            var helpedStudent1 = new HelpedStudent()
                 {
                     LastName = "Arsenault",
                     FirstName = "Marc",
                     EmailAdress = "marco.arso@hotmail.com"
                 };

            var helpedStudent2 = new HelpedStudent()
            {
                LastName = "Boilard",
                FirstName = "Éric",
                EmailAdress = "eric.r.boilard@coop.com"
            };

            var helpedStudent3 = new HelpedStudent()
            {
                LastName = "Couture",
                FirstName = "Jean-Cristophe",
                EmailAdress = "jc.couture.wilde@hotmail.com"
            };

            var helpedStudent4 = new HelpedStudent()
            {
                LastName = "Desrosiers",
                FirstName = "Julianne",
                EmailAdress = "galypo13@hotmail.com"
            };

            var helpedStudent5 = new HelpedStudent()
             {
                 LastName = "Arsenault",
                 FirstName = "Marc",
                 EmailAdress = "marco.arso@hotmail.com"
             };

            var helpedStudent6 = new HelpedStudent()
             {
                 LastName = "Grégoire-Allen",
                 FirstName = "Léo",
                 EmailAdress = "leoga@hotmail.com"
             };

            var helpedStudent7 = new HelpedStudent()
            {
                LastName = "Hamel",
                FirstName = "François"
            };

            var helpedStudent8 = new HelpedStudent()
             {
                 LastName = "Lepage",
                 FirstName = "Jérémy"
             };

            var helpedStudent9 = new HelpedStudent()
            {
                LastName = "Poitras",
                FirstName = "Nicolas"
            };

            var helpedStudent10 = new HelpedStudent()
            {
                LastName = "Roy-Gagnon",
                FirstName = "Samuel"
            };

            var helpedStudent11 = new HelpedStudent()
             {
                 LastName = "Simard",
                 FirstName = "Benjamin"
             };

            var helpedStudent12 = new HelpedStudent()
            {
                LastName = "Vachon",
                FirstName = "Samuel"
            };

            HelpedStudents.Add(helpedStudent1);
            HelpedStudents.Add(helpedStudent2);
            HelpedStudents.Add(helpedStudent3);
            HelpedStudents.Add(helpedStudent4);
            HelpedStudents.Add(helpedStudent5);
            HelpedStudents.Add(helpedStudent6);
            HelpedStudents.Add(helpedStudent7);
            HelpedStudents.Add(helpedStudent8);
            HelpedStudents.Add(helpedStudent9);
            HelpedStudents.Add(helpedStudent10);
            HelpedStudents.Add(helpedStudent11);
            HelpedStudents.Add(helpedStudent12);

            //Tutoring Sessions
            TutoringSessions.Add(new TutoringSession()
                {
                    DateSession = new DateTime(2015, 03, 16, 13, 0, 0),
                    LengthSession = 2,
                    HelpedID = helpedStudent5.Id,
                    TutorID = tutor5.Id
                });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 03, 24, 10, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent5.Id,
                TutorID = tutor1.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 03, 25, 13, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent2.Id,
                TutorID = tutor4.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 01, 12, 0, 0),
                LengthSession = 2,
                HelpedID = helpedStudent1.Id,
                TutorID = tutor5.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 01, 13, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent2.Id,
                TutorID = tutor3.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 06, 16, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent1.Id,
                TutorID = tutor4.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 08, 10, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent6.Id,
                TutorID = tutor4.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 10, 10, 0, 0),
                LengthSession = 2,
                HelpedID = helpedStudent1.Id,
                TutorID = tutor4.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 29, 12, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent9.Id,
                TutorID = tutor5.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 05, 25, 13, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent11.Id,
                TutorID = tutor7.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 05, 27, 12, 0, 0),
                LengthSession = 2,
                HelpedID = helpedStudent11.Id,
                TutorID = tutor5.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 05, 27, 13, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent2.Id,
                TutorID = tutor3.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 01, 09, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent7.Id,
                TutorID = tutor7.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 09, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent12.Id,
                TutorID = tutor7.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 11, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent2.Id,
                TutorID = tutor7.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 13, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent5.Id,
                TutorID = tutor1.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 15, 0, 0),
                LengthSession = 1,
                HelpedID = helpedStudent10.Id,
                TutorID = tutor4.Id
            });

            TutoringSessions.Add(new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 03, 13, 0, 0),
                LengthSession = 2,
                HelpedID = helpedStudent7.Id,
                TutorID = tutor3.Id
            });
        }
    }
}
