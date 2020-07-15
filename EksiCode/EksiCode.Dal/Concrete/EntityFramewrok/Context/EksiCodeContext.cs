using Microsoft.EntityFrameworkCore;

namespace EksiCode.Dal.Concrete.EntityFramewrok.Context
{
    public class EksiCodeContext : DbContext
    {
        public EksiCodeContext(DbContextOptions<EksiCodeContext> options) :base(options)
        {
            
        }
    }
}