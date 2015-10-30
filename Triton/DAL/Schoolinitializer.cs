using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Triton.Models;

namespace Triton.DAL
{
    //ha boviteni akarjuk az adatbazist, akkor a eldobjuk a regit,h kompatibilis legyen
    public class SchoolInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        //hallgatok inicializalasa
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>() {
                new Student(){FirstName="László",LastName="Nagy",EnrollmentDate=DateTime.Parse("2014/09/01")},
                new Student(){FirstName="Imre",LastName="Kiss",EnrollmentDate=DateTime.Parse("2013/09/01")},
                new Student(){FirstName="Peter",LastName="Kovacs",EnrollmentDate=DateTime.Parse("2014/08/27")},
                new Student(){FirstName="Zoltan",LastName="Szucs",EnrollmentDate=DateTime.Parse("2014/09/01")},
                new Student(){FirstName="Gabor",LastName="Horvath",EnrollmentDate=DateTime.Parse("2014/08/30")},
                new Student(){FirstName="Zoltan",LastName="Kádár",EnrollmentDate=DateTime.Parse("2014/09/01")}
            };

            students.ForEach(x => context.Students.Add(x));
            context.SaveChanges();

            //kurzusok inicializalasa
            var courses = new List<Course>(){
                new Course(){CourseID=1038,Title="Programozás",Credits=6},
                new Course(){CourseID=1040,Title="Matematika 1",Credits=1},
                new Course(){CourseID=1050,Title="Matematika 2",Credits=1},
                new Course(){CourseID=1060,Title="Matematika 3",Credits=1},
                new Course(){CourseID=1070,Title="Fizika",Credits=2},
                new Course(){CourseID=1080,Title="Kémia",Credits=2},
                new Course(){CourseID=1090,Title="Szoftvertechnoligia",Credits=2},
                new Course(){CourseID=1210,Title="Web Alkalmazasok",Credits=5},
                new Course(){CourseID=1222,Title="Informatika-tortenet",Credits=30},
                
            };

            foreach (var Course in courses)
            {
                context.Courses.Add(Course);
            }
            context.SaveChanges();

            //jelentkezesek inicializalasa

            var enrollments = new List<Enrollment>() { 
                new Enrollment(){StudentID=1,CourseID=1038,Grade=Grade.B},
                new Enrollment(){StudentID=2,CourseID=1038},
                new Enrollment(){StudentID=3,CourseID=1038,Grade=Grade.F},
                new Enrollment(){StudentID=4,CourseID=1038,Grade=Grade.E},
                new Enrollment(){StudentID=1,CourseID=1040},
                new Enrollment(){StudentID=2,CourseID=1040},
                new Enrollment(){StudentID=2,CourseID=1040,Grade=Grade.B},
                new Enrollment(){StudentID=4,CourseID=1040,},
                new Enrollment(){StudentID=1,CourseID=1050,Grade=Grade.C},
                new Enrollment(){StudentID=2,CourseID=1050},
                new Enrollment(){StudentID=3,CourseID=1050},
                new Enrollment(){StudentID=4,CourseID=1050},
                new Enrollment(){StudentID=1,CourseID=1222,Grade=Grade.A}
               };

            enrollments.ForEach(x => context.Enrollments.Add(x));
            context.SaveChanges();
        }

    }
}