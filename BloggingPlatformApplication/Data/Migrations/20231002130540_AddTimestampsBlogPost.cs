using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloggingPlatformApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTimestampsBlogPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
             name: "Created",
             table: "BlogPost",
             nullable: true);
            migrationBuilder.AddColumn<DateTime>(
             name: "LastUpdated",
             table: "BlogPost",
             nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
             name: "Created",
             table: "BlogPost");
            migrationBuilder.DropColumn(
             name: "LastUpdated",
             table: "BlogPost");
        }
    }
}
