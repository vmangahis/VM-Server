using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VM_Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialTableCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vm_experiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<string>(type: "text", nullable: true),
                    EndDate = table.Column<string>(type: "text", nullable: true),
                    RoleName = table.Column<string>(type: "text", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vm_experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vm_projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ImageLink = table.Column<string>(type: "text", nullable: true),
                    ProjectLink = table.Column<string>(type: "text", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vm_projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vm_skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SkillName = table.Column<string>(type: "text", nullable: true),
                    SkillDescription = table.Column<string>(type: "text", nullable: true),
                    SkillIdentifier = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vm_skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "vm_experiences",
                columns: new[] { "Id", "Company", "CreatedDateTime", "EndDate", "RoleName", "StartDate" },
                values: new object[,]
                {
                    { new Guid("07e0c23d-c4dd-4e27-b2d9-0e74284d7a79"), "DepEd Biñan City Division Information Office", new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(8266), "July 2022", "Frontend Developer", "April 2022" },
                    { new Guid("cadb233f-013c-4a65-82f5-d1865c640595"), "Upwork", new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(8277), "January 2023", "Freelance Virtual Assistant", "September 2020" },
                    { new Guid("ce2affed-4d36-462d-99dc-2479745c0c4a"), "Upwork", new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(8273), "January 2023", "Freelance Web Developer", "September 2020" }
                });

            migrationBuilder.InsertData(
                table: "vm_projects",
                columns: new[] { "Id", "CreatedDateTime", "ImageLink", "ProjectLink", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("8436f29f-bd2d-4dad-9411-7377e62e688c"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(7888), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/fcc_bi4o7r.png", "https://github.com/vmangahis/Four-Color-Conjecture-Game", "Four Color Conjecture Game" },
                    { new Guid("97d21240-7664-4e61-ac7c-6165b9bc3828"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(7906), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/apt_jd51xf.png", "https://github.com/vmangahis/apartment-rental-system", "Apartment Rental Management System" },
                    { new Guid("aa7a7e72-cfc2-4c6f-8665-9411bff2bdf6"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(7910), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954839/vmdev/kai_gb2jzi.png", "https://github.com/vmangahis/Kai", "Kai" },
                    { new Guid("aeff3345-8bcf-4aa1-b9fe-772c86a8abd0"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(7902), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954822/vmdev/beowulf_tfac0o.png", "https://github.com/vmangahis/beowulf", "Beowulf" }
                });

            migrationBuilder.InsertData(
                table: "vm_skills",
                columns: new[] { "Id", "CreatedDateTime", "SkillDescription", "SkillIdentifier", "SkillName" },
                values: new object[,]
                {
                    { new Guid("096e333d-81b0-47f4-847d-b64d225fb950"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(8146), null, "dotnet", ".NET Core" },
                    { new Guid("af917738-b231-45d7-86b5-1a735617e6c4"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(8143), null, "postgresql", "PostgreSQL" },
                    { new Guid("ca03be6c-f67d-40fe-882f-9847fb9e2352"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(8139), null, "django", "Django" },
                    { new Guid("f38508c1-df57-4885-852b-9aa0debff08f"), new DateTime(2024, 11, 7, 16, 47, 0, 70, DateTimeKind.Utc).AddTicks(8135), null, "msql_server", "Microsoft SQL Server" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vm_experiences");

            migrationBuilder.DropTable(
                name: "vm_projects");

            migrationBuilder.DropTable(
                name: "vm_skills");
        }
    }
}
