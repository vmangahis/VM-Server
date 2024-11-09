using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VM_Server.Model;

namespace VM_Server.Repositories.Configuration
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experiences>
    {
        public void Configure(EntityTypeBuilder<Experiences> builder)
        {
            builder.HasData(
                new Experiences
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Company = "DepEd Biñan City Division Information Office",
                    StartDate = new DateOnly(2022, 04, 01),
                    EndDate = new DateOnly(2022, 07, 01),
                    RoleName = "Frontend Developer",
                    CreatedDateTime = DateTime.UtcNow
                },
                new Experiences
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Company = "Upwork",
                    StartDate = new DateOnly(2020, 09, 01),
                    EndDate = new DateOnly(2023, 01, 01),
                    RoleName = "Freelance Web Developer",
                    CreatedDateTime = DateTime.UtcNow
                },
                new Experiences
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Company = "Upwork",
                    StartDate = new DateOnly(2020, 09, 01),
                    EndDate = new DateOnly(2023, 01, 01),
                    RoleName = "Freelance Virtual Assistant",
                    CreatedDateTime = DateTime.UtcNow
                }
             );
        }
    }
}
