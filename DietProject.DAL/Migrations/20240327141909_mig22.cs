using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "Adi", "Boy", "CreatedDate", "DeletedDate", "DogumTarihi", "EntityStatus", "Eposta", "Kilo", "Sifre", "Soyadi", "UpdatedDate", "UserStatus" },
                values: new object[] { 16, "Admin Adı", 175.0, new DateTime(2024, 3, 27, 17, 19, 9, 569, DateTimeKind.Local).AddTicks(4136), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "admin", 75.0, "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4", "Admin Soyadı", null, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
