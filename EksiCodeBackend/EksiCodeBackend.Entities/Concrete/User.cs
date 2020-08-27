using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EksiCodeBackend.Core.Entities;

namespace EksiCodeBackend.Entities.Concrete
{
    public class User:IBaseEntity
    {
        [Key]
        [Column("id", Order = 0)]
        public int id { get; set; }

        [Required]
        [Column("first_name", Order = 1)]
        public string firstName { get; set; }

        [Required]
        [Column("last_name", Order = 2)]
        public string lastName { get; set; }

        [Required]
        [Column("username", Order = 3)]
        public string username { get; set; }

        [Required]
        [Column("password", Order = 4)]
        public string password { get; set; }

        [Required]
        [Column("email", Order = 5)]
        public string email { get; set; }

        [Column("avatar", Order = 6)]
        public string avatar { get; set; }

        [Column("phone", Order = 7)]
        public string phone { get; set; }

        [Column("recovery_code", Order = 8)] 
        public string recoveryCode { get; set; }

        [Column("reputation", Order = 9)]
        public string reputation { get; set; }

        [Column("impact", Order = 10)]
        public string impact { get; set; }

        [Column("badges", Order = 11)]
        public string badges { get; set; }

        [Column("socials", Order = 12)]
        public string socials { get; set; }

        [Required]
        [Column(Order = 13)]
        [ForeignKey("role_id")]
        public Role Role { get; set; }

        [Required]
        [Column("created_at", Order = 14)]
        public DateTime createdAt { get; set; }
        
        [Required]
        [Column("updated_at", Order = 15)]
        public DateTime updatedAt { get; set; }
        
        [Required]
        [Column("status", Order = 16)]
        public bool status { get; set; }

	}
}
