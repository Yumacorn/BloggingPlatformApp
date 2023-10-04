using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BloggingPlatformApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDBBlogPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogPost",
                columns: new[] { "Id", "Content", "Created", "LastUpdated", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Starring Hugh Jackman and Zac Efron", new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2851), "The World's Greatest Showman", 1 },
                    { 2, "A biographical of the nonsensical and whimsical", new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2854), "From Now On", 1 },
                    { 3, "Home is where the Red Planet is", new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2856), new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2857), "Terraforming Mars", 2 },
                    { 4, "A series of unfortunate events in space", new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2860), "Don't trust the Detective", 2 },
                    { 5, "A quick guide to 1,000,000 berry bounties", new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 10, 4, 11, 38, 5, 468, DateTimeKind.Local).AddTicks(2863), "How to hone your Swordsman Skills", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
