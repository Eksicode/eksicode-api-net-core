using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EksiCodeBackend.Core.Entities;

namespace EksiCodeBackend.Entities.Concrete
{
    public class Role : IBaseEntity
    {
		[Key]
		[Column("id", Order = 0)]
		public int id { get; set; }

		[Column("name", Order = 1)]
		public string name { get; set; }

        [Required]
        [Column("created_at", Order = 2)]
        public DateTime createdAt { get; set; }

        [Required]
        [Column("updated_at", Order = 3)]
        public DateTime updatedAt { get; set; }

        [Required]
        [Column("status", Order = 4)]
        public bool status { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
