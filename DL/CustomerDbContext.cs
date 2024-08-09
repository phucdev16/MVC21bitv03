using DEVDOCNETMidtest.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace DEVDOCNETMidtest.DL
{
    public class CustomerDbContext : DbContext {
        public CustomerDbContext(DbContextOptions option) : base(option)
        { }

        public DbSet <Customer > customers { get; set; } 

        

    
        
    }
}
