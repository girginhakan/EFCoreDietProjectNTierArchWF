using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PorsiyonMiktari",
                table: "Porsiyonlar");

            migrationBuilder.AddColumn<double>(
                name: "PorsiyonMiktari",
                table: "Yemekler",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PorsiyonMiktari",
                table: "Yemekler");

            migrationBuilder.AddColumn<double>(
                name: "PorsiyonMiktari",
                table: "Porsiyonlar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
