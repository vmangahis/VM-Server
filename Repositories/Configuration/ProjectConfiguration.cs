using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VM_Server.Model;

namespace VM_Server.Repositories.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> builder)
        {
            builder.HasData(
                new Projects
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    ProjectName = "Four Color Conjecture Game",
                    ImageLink = "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/fcc_bi4o7r.png",
                    ProjectLink = "https://github.com/vmangahis/Four-Color-Conjecture-Game",
                    CreatedDateTime = DateTime.UtcNow,
                },
                new Projects
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    ProjectName = "Beowulf",
                    ImageLink = "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954822/vmdev/beowulf_tfac0o.png",
                    ProjectLink = "https://github.com/vmangahis/beowulf",
                    CreatedDateTime = DateTime.UtcNow,
                },
                new Projects
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    ProjectName = "Apartment Rental Management System",
                    ImageLink = "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/apt_jd51xf.png",
                    ProjectLink = "https://github.com/vmangahis/apartment-rental-system",
                    CreatedDateTime = DateTime.UtcNow,
                },
                new Projects
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    ProjectName = "Kai",
                    ImageLink = "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954839/vmdev/kai_gb2jzi.png",
                    ProjectLink = "https://github.com/vmangahis/Kai",
                    CreatedDateTime = DateTime.UtcNow,
                }
             );
        }
    }
}
