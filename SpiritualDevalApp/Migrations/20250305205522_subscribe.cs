using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpiritualDevalApp.Migrations
{
    /// <inheritdoc />
    public partial class subscribe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "subscribed_to_volunteer_updates",
                table: "UserAccounts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "subscribed_to_volunteer_updates",
                table: "UserAccounts");
        }
    }
}
