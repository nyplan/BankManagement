using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 7, 13, 39, 37, 979, DateTimeKind.Local).AddTicks(4193), null, null, "Kapital Bank " },
                    { 2, new DateTime(2023, 5, 7, 13, 39, 37, 979, DateTimeKind.Local).AddTicks(4209), null, null, "ABB" },
                    { 3, new DateTime(2023, 5, 7, 13, 39, 37, 979, DateTimeKind.Local).AddTicks(4213), null, null, "Merkezi Bank" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
