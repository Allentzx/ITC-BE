using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class Schools
    {
        [Key]
        public Guid Id { get; set; }
        public string? SchoolName { get; set; }
        public string? Address { get; set; }
    }
}
