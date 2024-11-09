using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VM_Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
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
                    { new Guid("0a2ec8c1-7a2c-4b69-9db5-f847a9f5fb69"), "DepEd Biñan City Division Information Office", new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(1562), new DateOnly(2022, 7, 1), "Frontend Developer", new DateOnly(2022, 4, 1) },
                    { new Guid("184f23b8-766a-4f39-a30c-c236bfcd5f12"), "Upwork", new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(1575), new DateOnly(2023, 1, 1), "Freelance Virtual Assistant", new DateOnly(2020, 9, 1) },
                    { new Guid("ab4535ed-bef5-411b-b61e-44ae40b942d8"), "Upwork", new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(1571), new DateOnly(2023, 1, 1), "Freelance Web Developer", new DateOnly(2020, 9, 1) }
                });

            migrationBuilder.InsertData(
                table: "vm_projects",
                columns: new[] { "Id", "CreatedDateTime", "ImageLink", "ProjectLink", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("259dc68f-e905-4d7e-9e9f-9ca9ccc0c8e3"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(841), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/apt_jd51xf.png", "https://github.com/vmangahis/apartment-rental-system", "Apartment Rental Management System" },
                    { new Guid("c2ed6d10-4d43-4fe8-8c32-f3dc100c238b"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(837), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954822/vmdev/beowulf_tfac0o.png", "https://github.com/vmangahis/beowulf", "Beowulf" },
                    { new Guid("c8edb8be-5798-4579-8086-000714062317"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(820), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/fcc_bi4o7r.png", "https://github.com/vmangahis/Four-Color-Conjecture-Game", "Four Color Conjecture Game" },
                    { new Guid("fec3ee5d-578a-48b6-9cea-23f80914ff03"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(844), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954839/vmdev/kai_gb2jzi.png", "https://github.com/vmangahis/Kai", "Kai" }
                });

            migrationBuilder.InsertData(
                table: "vm_skills",
                columns: new[] { "Id", "CreatedDateTime", "SkillDescription", "SkillIdentifier", "SkillName" },
                values: new object[,]
                {
                    { new Guid("17e3e3bb-d431-4a40-ac8c-0b228163dc14"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(1016), null, "dotnet", ".NET Core" },
                    { new Guid("4e2004ac-f795-4f0e-a2f6-69913969114e"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(1009), null, "django", "Django" },
                    { new Guid("6ffe5b5b-1735-44ed-bd21-a83bcbb5e59b"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(1013), null, "postgresql", "PostgreSQL" },
                    { new Guid("9141b775-f42b-459d-8469-1a1b05e299b8"), new DateTime(2024, 11, 9, 17, 35, 0, 483, DateTimeKind.Utc).AddTicks(1004), null, "msql_server", "Microsoft SQL Server" }
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
