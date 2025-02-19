using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpiritualDevalApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventRegistrations",
                columns: table => new
                {
                    event_registration_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    event_id = table.Column<int>(type: "int", nullable: false),
                    registration_date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrations", x => x.event_registration_id);
                    table.ForeignKey(
                        name: "FK_EventRegistrations_Events_event_id",
                        column: x => x.event_id,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventRegistrations_UserAccounts_user_id",
                        column: x => x.user_id,
                        principalTable: "UserAccounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VolunteerRegistrations",
                columns: table => new
                {
                    volunteer_registration_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    event_id = table.Column<int>(type: "int", nullable: false),
                    registration_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    skills_provided = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerRegistrations", x => x.volunteer_registration_id);
                    table.ForeignKey(
                        name: "FK_VolunteerRegistrations_Events_event_id",
                        column: x => x.event_id,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerRegistrations_UserAccounts_user_id",
                        column: x => x.user_id,
                        principalTable: "UserAccounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrations_event_id",
                table: "EventRegistrations",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrations_user_id",
                table: "EventRegistrations",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerRegistrations_event_id",
                table: "VolunteerRegistrations",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerRegistrations_user_id",
                table: "VolunteerRegistrations",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventRegistrations");

            migrationBuilder.DropTable(
                name: "VolunteerRegistrations");
        }
    }
}
