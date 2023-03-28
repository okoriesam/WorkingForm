using MetrosoftForm.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MetrosoftForm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
