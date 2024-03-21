using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yemekler_Kategoriler_kategoriId",
                table: "Yemekler");

            migrationBuilder.RenameColumn(
                name: "kategoriId",
                table: "Yemekler",
                newName: "KategoriId");

            migrationBuilder.RenameIndex(
                name: "IX_Yemekler_kategoriId",
                table: "Yemekler",
                newName: "IX_Yemekler_KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yemekler_Kategoriler_KategoriId",
                table: "Yemekler",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yemekler_Kategoriler_KategoriId",
                table: "Yemekler");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "Yemekler",
                newName: "kategoriId");

            migrationBuilder.RenameIndex(
                name: "IX_Yemekler_KategoriId",
                table: "Yemekler",
                newName: "IX_Yemekler_kategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yemekler_Kategoriler_kategoriId",
                table: "Yemekler",
                column: "kategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
