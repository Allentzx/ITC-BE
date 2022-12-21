using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Images
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Url { get; set; }
        public Guid RevId { get; set; }
        [ForeignKey("RevId")]
        public Guid SchooldId { get; set; }
        [ForeignKey("SchooldId")]
        public virtual Review? Reviews { get; set; }
        public virtual Schools? Schools { get; set; }
    }
}
