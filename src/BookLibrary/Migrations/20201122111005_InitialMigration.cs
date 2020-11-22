using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ReservedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Reservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "PasswordHash", "Salt" },
                values: new object[] { 1, "Admin", new byte[] { 33, 173, 185, 225, 35, 187, 51, 176, 89, 232, 184, 222, 111, 219, 212, 232, 172, 215, 208, 105, 95, 51, 223, 194, 169, 54, 125, 40, 195, 213, 190, 145, 199, 174, 176, 160, 225, 53, 5, 119, 238, 132, 77, 204, 90, 151, 68, 130, 252, 16, 110, 8, 238, 182, 66, 238, 192, 54, 180, 228, 86, 119, 146, 67 }, new byte[] { 137, 123, 123, 205, 164, 116, 20, 175, 73, 203, 26, 98, 141, 86, 206, 78, 182, 5, 201, 25, 164, 220, 157, 158, 15, 66, 240, 121, 90, 63, 24, 44, 145, 111, 173, 13, 43, 250, 244, 75, 112, 174, 40, 194, 66, 137, 167, 212, 136, 16, 7, 177, 162, 111, 197, 134, 131, 207, 253, 19, 29, 160, 122, 38, 148, 66, 6, 33, 118, 5, 182, 93, 136, 47, 183, 183, 147, 78, 115, 22, 232, 231, 81, 220, 9, 108, 11, 217, 41, 78, 136, 33, 80, 132, 1, 54, 188, 162, 39, 217, 19, 187, 83, 169, 208, 128, 139, 210, 5, 13, 144, 134, 91, 77, 60, 74, 140, 164, 225, 62, 119, 9, 74, 152, 216, 127, 48, 142 } });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
