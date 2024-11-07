using Microsoft.EntityFrameworkCore;
using VM_Server.Model;
using VM_Server.Repositories.Configuration;

namespace VM_Server.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions opt): base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new SkillsConfiguration());
            modelBuilder.ApplyConfiguration(new ExperienceConfiguration());
        }

        public DbSet<Experiences>? vm_experiences { get; set; }
        public DbSet<Projects>? vm_projects { get; set; }
        public DbSet<Skills>? vm_skills { get; set; }
    }
}
