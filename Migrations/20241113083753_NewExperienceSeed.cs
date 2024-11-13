using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VM_Server.Migrations
{
    /// <inheritdoc />
    public partial class NewExperienceSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("0a2ec8c1-7a2c-4b69-9db5-f847a9f5fb69"));

            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("184f23b8-766a-4f39-a30c-c236bfcd5f12"));

            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("ab4535ed-bef5-411b-b61e-44ae40b942d8"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("259dc68f-e905-4d7e-9e9f-9ca9ccc0c8e3"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("c2ed6d10-4d43-4fe8-8c32-f3dc100c238b"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("c8edb8be-5798-4579-8086-000714062317"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("fec3ee5d-578a-48b6-9cea-23f80914ff03"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("17e3e3bb-d431-4a40-ac8c-0b228163dc14"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("4e2004ac-f795-4f0e-a2f6-69913969114e"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("6ffe5b5b-1735-44ed-bd21-a83bcbb5e59b"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("9141b775-f42b-459d-8469-1a1b05e299b8"));

            migrationBuilder.InsertData(
                table: "vm_experiences",
                columns: new[] { "Id", "Company", "CreatedDateTime", "EndDate", "RoleName", "StartDate" },
                values: new object[,]
                {
                    { new Guid("05dd9635-f9a6-429f-b2e9-b3dbb4d38ad3"), "Upwork", new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9983), new DateOnly(2023, 1, 1), "Freelance Virtual Assistant", new DateOnly(2020, 9, 1) },
                    { new Guid("16543560-d199-45ca-a89e-62939525fb93"), "Upwork", new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9980), new DateOnly(2023, 1, 1), "Freelance Web Developer", new DateOnly(2020, 9, 1) },
                    { new Guid("35c6b152-a07f-44a5-890f-b7e76fb6cf4b"), "DepEd Biñan City Division Information Office", new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9974), new DateOnly(2022, 7, 1), "Frontend Developer", new DateOnly(2022, 4, 1) },
                    { new Guid("a8af479c-e5c3-443b-8d89-5606e4bfbdf9"), "Infor PSSC Inc.", new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9990), null, "Software Engineer", new DateOnly(2023, 6, 1) },
                    { new Guid("c6abd0a3-ce38-4689-aaa4-d298de5da4cd"), "Infor PSSC Inc.", new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9987), new DateOnly(2024, 6, 1), "Associate Software Engineer", new DateOnly(2023, 2, 13) }
                });

            migrationBuilder.InsertData(
                table: "vm_projects",
                columns: new[] { "Id", "CreatedDateTime", "ImageLink", "ProjectLink", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("0adcd973-d932-4802-a980-0275f7393d63"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9640), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/fcc_bi4o7r.png", "https://github.com/vmangahis/Four-Color-Conjecture-Game", "Four Color Conjecture Game" },
                    { new Guid("2aea85d5-7837-49e3-9778-b80e24ccf4d6"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9647), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954820/vmdev/apt_jd51xf.png", "https://github.com/vmangahis/apartment-rental-system", "Apartment Rental Management System" },
                    { new Guid("3e5ad967-6383-4693-86ee-a31dfb6b2621"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9650), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954839/vmdev/kai_gb2jzi.png", "https://github.com/vmangahis/Kai", "Kai" },
                    { new Guid("7a41c941-6c46-4322-9ee4-51b0307c67ea"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9644), "https://res.cloudinary.com/dg1bym3ax/image/upload/v1730954822/vmdev/beowulf_tfac0o.png", "https://github.com/vmangahis/beowulf", "Beowulf" }
                });

            migrationBuilder.InsertData(
                table: "vm_skills",
                columns: new[] { "Id", "CreatedDateTime", "SkillDescription", "SkillIdentifier", "SkillName" },
                values: new object[,]
                {
                    { new Guid("2b831bfa-492e-4200-a218-667bc6b500a3"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9842), null, "dotnet", ".NET Core" },
                    { new Guid("70aa8218-7d37-4406-bad3-6db7f605e875"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9838), null, "postgresql", "PostgreSQL" },
                    { new Guid("7a9b937d-5a12-43f6-927c-4c5944650986"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9834), null, "django", "Django" },
                    { new Guid("f3a92a7e-f95c-40ea-af79-3831fae65dc2"), new DateTime(2024, 11, 13, 8, 37, 52, 960, DateTimeKind.Utc).AddTicks(9829), null, "msql_server", "Microsoft SQL Server" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("05dd9635-f9a6-429f-b2e9-b3dbb4d38ad3"));

            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("16543560-d199-45ca-a89e-62939525fb93"));

            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("35c6b152-a07f-44a5-890f-b7e76fb6cf4b"));

            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("a8af479c-e5c3-443b-8d89-5606e4bfbdf9"));

            migrationBuilder.DeleteData(
                table: "vm_experiences",
                keyColumn: "Id",
                keyValue: new Guid("c6abd0a3-ce38-4689-aaa4-d298de5da4cd"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("0adcd973-d932-4802-a980-0275f7393d63"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("2aea85d5-7837-49e3-9778-b80e24ccf4d6"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("3e5ad967-6383-4693-86ee-a31dfb6b2621"));

            migrationBuilder.DeleteData(
                table: "vm_projects",
                keyColumn: "Id",
                keyValue: new Guid("7a41c941-6c46-4322-9ee4-51b0307c67ea"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("2b831bfa-492e-4200-a218-667bc6b500a3"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("70aa8218-7d37-4406-bad3-6db7f605e875"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("7a9b937d-5a12-43f6-927c-4c5944650986"));

            migrationBuilder.DeleteData(
                table: "vm_skills",
                keyColumn: "Id",
                keyValue: new Guid("f3a92a7e-f95c-40ea-af79-3831fae65dc2"));

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
    }
}
