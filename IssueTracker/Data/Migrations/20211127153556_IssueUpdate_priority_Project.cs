using Microsoft.EntityFrameworkCore.Migrations;

namespace IssueTracker.Data.Migrations
{
    public partial class IssueUpdate_priority_Project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IssuePriority",
                table: "Issue",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IssueProjectLocation",
                table: "Issue",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssuePriority",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "IssueProjectLocation",
                table: "Issue");
        }
    }
}
