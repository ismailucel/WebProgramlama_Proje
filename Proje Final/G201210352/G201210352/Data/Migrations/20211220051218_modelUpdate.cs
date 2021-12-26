using Microsoft.EntityFrameworkCore.Migrations;

namespace G201210352.Data.Migrations
{
    public partial class modelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstPhoto",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondPhoto",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdPhoto",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstPhoto",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "SecondPhoto",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "ThirdPhoto",
                table: "Song");
        }
    }
}
