using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class StudentInformation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? FullName { get; set; }
        public string? PassportNumber { get; set; }
        public string? PassportDate { get; set; }
        public string? ImagePassport { get; set; }
        public string? StatusTuitionFee { get; set; }
        public string? ImageBillTuitionFee { get; set; }
        public string? PercentAccept { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid SubId { get; set; }
        [ForeignKey("SubId")]
        public Guid ExamId { get; set; }
        [ForeignKey("ExamId")]
        public Guid SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public virtual Schools? Schools { get; set; }
        public virtual Exam? Exams { get; set; }
        public virtual SubCategory? SubCategories { get; set; }
        public virtual ICollection<User>? Users { get; set; }
    }
}
