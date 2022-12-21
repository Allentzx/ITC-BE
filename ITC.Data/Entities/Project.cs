using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Project
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        public string? TotalStudent { get; set; }
        public string? TotalStaff { get; set; }
        public string? Leader { get; set; }
        public string? Localtion { get; set; }
        public string? MyProperty { get; set; }
        public DateTime Time { get; set; }
        public DateTime MountOfTime { get; set; }
        public string? Introduction { get; set; }
        public Guid CoursePlanId { get; set; }
        [ForeignKey("CoursePlanId")]
        public Guid SubId { get; set; }
        [ForeignKey("SubId")]
        public virtual SubCategory? SubCategories { get; set; }
        public virtual CoursePlans? CoursePlans { get; set; }
        public virtual ICollection<PartnersInformation>? PartnersInformations { get; set; }
        public virtual ICollection<Schools>? Schools { get; set; }
        public virtual ICollection<EmpTasks>? EmpTasks { get; set; }
    }
}
