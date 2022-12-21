using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Review
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? PostDay { get; set; }
        public string? Author { get; set; }
        public string? Information { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual ICollection<Images>? Images { get; set; }

    }
}
