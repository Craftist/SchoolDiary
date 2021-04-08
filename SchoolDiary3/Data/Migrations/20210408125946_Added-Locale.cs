using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolDiary3.Data.Migrations
{
    public partial class AddedLocale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Locale",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "'en'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Locale",
                table: "AspNetUsers");
        }
    }
}
