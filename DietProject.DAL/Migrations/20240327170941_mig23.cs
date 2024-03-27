using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PorsiyonMiktari",
                table: "Yemekler");

            migrationBuilder.AddColumn<double>(
                name: "PorsiyonMiktari",
                table: "KullaniciOgunYemekPorsiyonlar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 27, 20, 9, 41, 336, DateTimeKind.Local).AddTicks(9936));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PorsiyonMiktari",
                table: "KullaniciOgunYemekPorsiyonlar");

            migrationBuilder.AddColumn<double>(
                name: "PorsiyonMiktari",
                table: "Yemekler",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 27, 17, 19, 9, 569, DateTimeKind.Local).AddTicks(4136));
        }
    }
}
