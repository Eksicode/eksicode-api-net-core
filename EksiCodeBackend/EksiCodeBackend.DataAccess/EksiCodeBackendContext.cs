using EksiCodeBackend.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EksiCodeBackend.DataAccess
{
    public class EksiCodeBackendContext : DbContext
    {

        public EksiCodeBackendContext()
        { 
        
        }

        public EksiCodeBackendContext(DbContextOptions<EksiCodeBackendContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
