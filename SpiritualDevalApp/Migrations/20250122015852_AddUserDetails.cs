using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpiritualDevalApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_account",
                table: "user_account");

            migrationBuilder.RenameTable(
                name: "user_account",
                newName: "UserAccounts");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "UserAccounts",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "UserAccounts",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "UserAccounts",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "email",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                newName: "user_account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_account",
                table: "user_account",
                column: "id");
        }
    }
}
