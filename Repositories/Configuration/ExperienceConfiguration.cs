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
                    StartDate = "April 2022",
                    EndDate = "July 2022",
                    RoleName = "Frontend Developer",
                    CreatedDateTime = DateTime.UtcNow
                },
                new Experiences
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Company = "Upwork",
                    StartDate = "September 2020",
                    EndDate = "January 2023",
                    RoleName = "Freelance Web Developer",
                    CreatedDateTime = DateTime.UtcNow
                },
                new Experiences
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Company = "Upwork",
                    StartDate = "September 2020",
                    EndDate = "January 2023",
                    RoleName = "Freelance Virtual Assistant",
                    CreatedDateTime = DateTime.UtcNow
                }
             );
        }
    }
}
