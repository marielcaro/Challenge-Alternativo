using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeoApi.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Denominacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Denominacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poblacion = table.Column<int>(type: "int", nullable: false),
                    Superficie = table.Column<int>(type: "int", nullable: false),
                    ContinetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Continets_ContinetId",
                        column: x => x.ContinetId,
                        principalTable: "Continets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeographicIcons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Denominacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Historia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    ContinentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicIcons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeographicIcons_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeographicIcons_Continets_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ContinetId",
                table: "City",
                column: "ContinetId");

            migrationBuilder.CreateIndex(
                name: "IX_GeographicIcons_CityId",
                table: "GeographicIcons",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_GeographicIcons_ContinentId",
                table: "GeographicIcons",
                column: "ContinentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeographicIcons");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Continets");
        }
    }
}
