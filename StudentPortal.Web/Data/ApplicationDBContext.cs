using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entites;

namespace StudentPortal.Web.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option): base(option)
        {
            
        }

        public DbSet<Student> Students { get; set; }

    }
}
