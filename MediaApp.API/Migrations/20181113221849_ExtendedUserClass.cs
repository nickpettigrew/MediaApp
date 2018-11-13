using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaApp.API.Migrations
{
    public partial class ExtendedUserClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ABN",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUploaded",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsFavorite = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Videos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Videos_UserId",
                table: "Videos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropColumn(
                name: "ABN",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastUploaded",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Users");
        }
    }
}
