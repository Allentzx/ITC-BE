using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ITC.Data.Entities
{
	public class RoleUser
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleUserId { get; set; }
        public Guid RolesId { get; set; }
        public Guid UsersId { get; set; }

        public virtual Role Roles { get; set; }
        public virtual User Users { get; set; }

    }
}

