using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITC.Data.Entities
{
	public class User
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]		
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public Guid SubId { get; set; }
        [ForeignKey("SubId")]
        public Guid StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual SubCategory? SubCategories { get; set; }
        public virtual StudentInformation? StudentInformations { get; set; }
        public virtual ICollection<RoleUser>? RoleUsers { get; set; }
    }
}

