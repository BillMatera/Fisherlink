using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisherLink.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructor { get; set; }
        public IEnumerable<Course> Course { get; set; }
        public IEnumerable<Enrollment> Enrollment { get; set; }
    }
}