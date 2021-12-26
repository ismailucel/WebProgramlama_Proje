using Microsoft.EntityFrameworkCore.Migrations;

namespace G201210352.Data.Migrations
{
    public partial class minorModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOrderOk",
                table: "Basket");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Basket",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Basket");

            migrationBuilder.AddColumn<bool>(
                name: "IsOrderOk",
                table: "Basket",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
