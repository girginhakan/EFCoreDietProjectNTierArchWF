using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_KullaniciDetaylar_KullaniciDetayId",
                table: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "KullaniciDetaylar");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_KullaniciDetayId",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciDetayId",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<string>(
                name: "Adi",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Boy",
                table: "Kullanicilar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "Kullanicilar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Kilo",
                table: "Kullanicilar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Soyadi",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adi",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Boy",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Kilo",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Soyadi",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciDetayId",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "KullaniciDetaylar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciDetaylar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciDetayId",
                table: "Kullanicilar",
                column: "KullaniciDetayId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_KullaniciDetaylar_KullaniciDetayId",
                table: "Kullanicilar",
                column: "KullaniciDetayId",
                principalTable: "KullaniciDetaylar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
