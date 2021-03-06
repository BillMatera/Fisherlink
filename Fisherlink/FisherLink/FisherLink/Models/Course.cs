﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FisherLink.Data;

namespace FisherLink.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 5)]//Test this****
        public int Credits { get; set; }
        [Column("Lat")]
        public double? lat { get; set; }
        [Column("Lng")]
        public double? lng { get; set; }

        public string Building { get; set; }

        public int DepartmentID { get; set; }

        public Department Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}