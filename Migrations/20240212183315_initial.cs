using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCryptoScanner.UI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    En = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    De = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Es = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    It = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZhTw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Th = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Da = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    El = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    He = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coins_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coins_DescriptionId",
                table: "Coins",
                column: "DescriptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");

            migrationBuilder.DropTable(
                name: "Description");
        }
    }
}
