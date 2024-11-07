using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VM_Server.Model;

namespace VM_Server.Repositories.Configuration
{
    public class SkillsConfiguration : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            builder.HasData(
                new Skills
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    CreatedDateTime = DateTime.UtcNow,
                    SkillName = "Microsoft SQL Server",
                    SkillDescription = null,
                    SkillIdentifier = "msql_server",
                },
                new Skills
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    CreatedDateTime = DateTime.UtcNow,
                    SkillName = "Django",
                    SkillDescription = null,
                    SkillIdentifier = "django",
                },
                new Skills
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    CreatedDateTime = DateTime.UtcNow,
                    SkillName = "PostgreSQL",
                    SkillDescription = null,
                    SkillIdentifier = "postgresql",
                },
                new Skills
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    CreatedDateTime = DateTime.UtcNow,
                    SkillName = ".NET Core",
                    SkillDescription = null,
                    SkillIdentifier = "dotnet",
                }
            );
        }
    }
}
