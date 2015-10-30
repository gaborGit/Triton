using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triton.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
        //jelentkezés hivatkozasa
        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}