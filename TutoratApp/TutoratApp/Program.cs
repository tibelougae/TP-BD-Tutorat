using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratApp.Controller;

namespace TutoratApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var helpedStudentRepository = new EfEntityRepository<HelpedStudent>();
            var tutorRepository = new EfEntityRepository<Tutor>();
            var sessionRepository = new EfEntityRepository<TutoringSession>();

            EfDataBaseHelper dataBase = new EfDataBaseHelper();
            dataBase.SeedDataBase();

            Console.WriteLine("B2 - liste tuteur");
            TutorController tutorController = new TutorController(tutorRepository);
            tutorController.showAllTutors();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("B2 - liste helpedStudent");
            HelpedStudentController helpedController = new HelpedStudentController(helpedStudentRepository);
            helpedController.showAllHelpedStudents();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("B2 - liste session");
            TutoringSessionController sessionController = new TutoringSessionController(sessionRepository);
            sessionController.showAllTutoringSessions();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("liste tuteur avec heure total");
            tutorController.showAllTutoringSessionsWithHours();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("liste tuteur avec heure total planifiée");
            tutorController.showAllTutoringSessionsWithHoursPlanned();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("liste aidé sans tutorat");
            helpedController.showAllHelpedStudentsWithoutTutoring();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("liste aidé sans tutorat le 02 juin 2015");
            tutorController.showAllTutorsWithoutSessionAt(new DateTime(2015, 06, 02));
            Console.WriteLine("-------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
