using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class PieModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsInStock",
                table: "Pies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Pies");
        }
    }
}
