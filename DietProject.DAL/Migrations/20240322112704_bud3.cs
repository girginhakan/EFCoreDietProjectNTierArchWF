using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class bud3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ToplamKalori",
                table: "KullaniciOgunYemekPorsiyonlar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToplamKalori",
                table: "KullaniciOgunYemekPorsiyonlar");
        }
    }
}
