using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace StudentRegInternPj.Entities
{
    [Table("Student")]
    public partial class Student
    {
        [Key]
        [StringLength(50)]
        public string StudentId { get; set; }
        [StringLength(100)]
        public string StudentName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AttendDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ResignDate { get; set; }
        [StringLength(256)]
        public string DetaillAddress { get; set; }
    }
}
