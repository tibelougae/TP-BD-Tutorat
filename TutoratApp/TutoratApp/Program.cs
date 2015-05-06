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
            sessionController.showAllTutoringSessions(helpedStudentRepository, tutorRepository);
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("liste tuteur avec heure total");
            sessionController.showAllTutoringSessionsWithHours(tutorRepository);
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("liste tuteur avec heure total planifiée");
            sessionController.showAllTutoringSessionsWithHoursPlanned(helpedStudentRepository, tutorRepository);
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("liste aidé sans tutorat");
            sessionController.showAllHelpedStudentsWithoutTutoring(helpedStudentRepository, tutorRepository);
            Console.WriteLine("-------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
