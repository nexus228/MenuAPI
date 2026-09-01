using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuAPI.Migrations
{
    /// <inheritdoc />
    public partial class ReceiptURLandImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Meal",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptURL",
                table: "Meal",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "ReceiptURL",
                table: "Meal");
        }
    }
}
