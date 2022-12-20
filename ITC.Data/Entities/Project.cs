using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        public int TotalStudent { get; set; }
        public int TotalStaff { get; set; }
        public string? Leader { get; set; }
        public string? Localtion { get; set; }
        public string? MyProperty { get; set; }
        public DateTime Time { get; set; }
        public DateTime MountOfTime { get; set; }
        public string? Introduction { get; set; }

    }
}
