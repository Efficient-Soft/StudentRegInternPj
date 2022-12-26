using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace StudentRegInternPj.Entities
{
    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        [StringLength(50)]
        public string PaymentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(50)]
        public string StudentId { get; set; }
        public int? CourseId { get; set; }
        public double? PaymentAmt { get; set; }
        [StringLength(256)]
        public string ReceiveUserId { get; set; }
    }
}
