using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProject.Migrations
{
    /// <inheritdoc />
    public partial class DBChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Album",
                newName: "Pages");

            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Album",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Album",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Album",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OriginalTitle",
                table: "Album",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReleaseDate",
                table: "Album",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "OriginalTitle",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Album");

            migrationBuilder.RenameColumn(
                name: "Pages",
                table: "Album",
                newName: "UserId");
        }
    }
}
