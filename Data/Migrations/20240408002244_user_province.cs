using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class user_province : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Contact",
                newName: "Province");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Contact",
                newName: "Postcode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Province",
                table: "Contact",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "Contact",
                newName: "State");
        }
    }
}
