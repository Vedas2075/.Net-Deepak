using AssigmentsManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace AssigmentsManagement.Data
{
    public class AssignmentMgmtDb : DbContext
    {
        public AssignmentMgmtDb(DbContextOptions<AssignmentMgmtDb> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<College> Colleges { get; set; }
    }
}
