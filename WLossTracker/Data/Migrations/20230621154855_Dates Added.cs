using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WLossTracker.Data.Migrations
{
    public partial class DatesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Weight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Weight");
        }
    }
}
