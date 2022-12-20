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
        [ForeignKey("Name")]
        public string? Name { get; set; }
        public virtual Score? Scores { get; set; }
    }
}
