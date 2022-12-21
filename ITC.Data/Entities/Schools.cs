using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Schools
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? SchoolName { get; set; }
        public string? Address { get; set; }
        public Guid ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public virtual Project? Projects { get; set; }
        public virtual ICollection<Images>? Images { get; set; }
        public virtual ICollection<Payment>? Payments { get; set; }
        public virtual ICollection<LessonPlan>? LessonPlans { get; set; }
        public virtual ICollection<StudentInformation>? StudentInformations { get; set; }
    }
}
