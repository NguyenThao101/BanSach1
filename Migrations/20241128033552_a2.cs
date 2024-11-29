using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanSach.Migrations
{
    /// <inheritdoc />
    public partial class a2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Address");

            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "WardId",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
