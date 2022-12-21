using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Exam
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? TotalPoint { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Name")]
        public Guid CoursePlanId { get; set; }
        [ForeignKey("CoursePlanId")]
        public Guid StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual StudentInformation? Students { get; set; }
        public virtual Score? Scores { get; set; }
        public virtual CoursePlans? CoursePlans { get; set; }

    }
}
