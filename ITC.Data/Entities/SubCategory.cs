using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class SubCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public virtual Category? Categories { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<LessonPlan>? LessonPlans { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }
        public virtual ICollection<StudentInformation>? StudentInformations { get; set; }
    }
}
