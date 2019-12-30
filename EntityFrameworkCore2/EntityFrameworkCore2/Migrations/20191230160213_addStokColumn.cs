using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore2.Migrations
{
    public partial class addStokColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StokUnit",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StokUnit",
                table: "Products");
        }
    }
}
