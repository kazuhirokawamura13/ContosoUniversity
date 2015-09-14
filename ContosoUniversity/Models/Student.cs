using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation Property --> Holds other entities that are related
        // to that Student entity. Navigation properties are typically
        // defined as virtual so we can take advantage of EF's lazy loading
        // functionality
        public virtual ICollection<Enrollment> Enrollments{ get; set; }
    }
}