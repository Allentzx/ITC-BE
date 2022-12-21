using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Comments { get; set; }
        public Guid ReviewId { get; set; }
        [ForeignKey("ReviewId")]
        public Guid StudentId { get; set; }
        [ForeignKey("StudentId")]

        public Guid ParentId { get; set; }

        public virtual Review? Reviews { get; set; }
        public virtual StudentInformation? Students { get; set; }

    }
}
