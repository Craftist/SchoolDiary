using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolDiary3.Data.Migrations
{
    public partial class AddedGradeLetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GradeLetter",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 2,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeLetter",
                table: "AspNetUsers");
        }
    }
}
