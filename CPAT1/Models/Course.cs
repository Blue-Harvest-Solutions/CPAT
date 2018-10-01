using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPAT1.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseID { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }

        public int[] PreRequisites { get; set; }
        public int[] CoRequisites { get; set; }

        public void GetPreReqs()
        {

        }

    }
}
