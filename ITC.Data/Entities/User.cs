using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITC.Data.Entities
{
	public class User
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]		
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? FullName { get; set; }
        public string? Password { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
    }
}

