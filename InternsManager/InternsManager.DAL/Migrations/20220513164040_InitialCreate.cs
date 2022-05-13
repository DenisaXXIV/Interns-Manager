using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternsManager.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Interns",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicPath",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Interns",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicPath",
                value: null);
        }
    }
}
