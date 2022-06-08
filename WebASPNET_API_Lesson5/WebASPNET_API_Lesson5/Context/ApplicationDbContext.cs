using Microsoft.EntityFrameworkCore;
using WebASPNET_API_Lesson5.Models;

namespace WebASPNET_API_Lesson5.Context
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<SaveRequestInfo> SaveRequestInfo { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
    }
}
