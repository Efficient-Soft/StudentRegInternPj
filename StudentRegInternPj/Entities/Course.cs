using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace StudentRegInternPj.Entities
{
    [Table("Course")]
    public partial class Course
    {
        [Key]
        public int CourseId { get; set; }
        [StringLength(100)]
        public string CourseName { get; set; }
        public bool Status { get; set; }
    }
}
