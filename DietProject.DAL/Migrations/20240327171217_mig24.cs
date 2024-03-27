using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 27, 20, 12, 17, 396, DateTimeKind.Local).AddTicks(7344));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 27, 20, 9, 41, 336, DateTimeKind.Local).AddTicks(9936));
        }
    }
}
