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
        private List<TutoringSession> tutoringSessions = new List<TutoringSession>();

        public void Add(TutoringSession tutoringSession)
        {
            tutoringSessions.Add(tutoringSession);
        }

        public void Clear()
        {
            tutoringSessions.Clear();
        }

        public void showTutoringSession(EfEntityRepository<HelpedStudent> helpedStudents, EfEntityRepository<Tutor> tutors)
        {
            foreach (TutoringSession tutoringSession in tutoringSessions)
            {
                Console.WriteLine(tutoringSession.DateSession.Day + "-" + tutoringSession.DateSession.Month + "-" + tutoringSession.DateSession.Year + ", "
                        + tutoringSession.DateSession.Hour + ", "
                        + tutoringSession.LengthSession + ", "
                        + helpedStudents.GetById(tutoringSession.HelpedID).LastName + "," + helpedStudents.GetById(tutoringSession.HelpedID).FirstName + "," + helpedStudents.GetById(tutoringSession.HelpedID).EmailAdress
                        + tutors.GetById(tutoringSession.TutorID).LastName + "," + tutors.GetById(tutoringSession.TutorID).FirstName + "," + tutors.GetById(tutoringSession.TutorID).EmailAdress);
            }
        }

        public void showPlannedTutoringSessions(EfEntityRepository<HelpedStudent> helpedStudents, EfEntityRepository<Tutor> tutors)
        {
            foreach (Tutor tutor in tutors.GetAll())
            {
                Console.WriteLine(tutor.FirstName + " et " + tutor.LastName);
                foreach (TutoringSession tutoringSession in tutoringSessions)
                {
                    if (tutor.Id == tutoringSession.TutorID)
                    {
                        Console.WriteLine(tutoringSession.DateSession.Day + "-" + tutoringSession.DateSession.Month + "-" + tutoringSession.DateSession.Year + ", "
                                + tutoringSession.DateSession.Hour + ", "
                                + tutoringSession.LengthSession + ", "
                                + helpedStudents.GetById(tutoringSession.HelpedID).LastName + "," + helpedStudents.GetById(tutoringSession.HelpedID).FirstName + "," + helpedStudents.GetById(tutoringSession.HelpedID).EmailAdress);
                    }
                }
            }
        }

        public void showStudentsWithoutTutoring(EfEntityRepository<HelpedStudent> helpedStudents)
        {
            IQueryable<HelpedStudent> studentsWithoutTutoring = helpedStudents.GetAll();
            var queryStudentsWithTutoring =
                from session in tutoringSessions
                join student in studentsWithoutTutoring on session.HelpedID equals student.Id into studentGroup
                select session;

            foreach (var queryResult in queryStudentsWithTutoring)
            {

                Console.WriteLine(helpedStudents.GetById(queryResult.HelpedID).LastName + "," + helpedStudents.GetById(queryResult.HelpedID).FirstName + "," + helpedStudents.GetById(queryResult.HelpedID).EmailAdress);
                
            }
        }
    }
}
