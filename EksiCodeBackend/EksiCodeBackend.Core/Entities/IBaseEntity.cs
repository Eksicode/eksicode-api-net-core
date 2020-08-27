using System;
using System.Collections.Generic;
using System.Text;

namespace EksiCodeBackend.Core.Entities
{
    public interface IBaseEntity
    {
        public int id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool status { get; set; }
    }
}
