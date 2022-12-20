using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Score
    {

        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Percent { get; set; }
        public string? Minimumpass { get; set; }
        public string? ParentId { get; set; }

    }
}
