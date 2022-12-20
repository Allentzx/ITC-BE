using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Entities
{
    public class PartnersInformation
    {
        [Key]
        public Guid Id { get; set; }
        public string? PartnerName { get; set; }
        public string? Contact { get; set; }
        public string? Features { get; set; }
        public string? Notes { get; set; }
    }
}
