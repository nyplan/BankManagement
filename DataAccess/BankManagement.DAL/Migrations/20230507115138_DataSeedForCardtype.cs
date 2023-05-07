using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedForCardtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "BankId", "CashBack", "Comission", "CreatedAt", "DeletedAt", "MaxCapacity", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, 1, 0m, 10m, new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9387), null, 10000m, null, "Bir Kart" },
                    { 2, 1, 5m, 0m, new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9389), null, 5000m, null, "Premium Kart" },
                    { 3, 2, 0m, 5m, new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9390), null, 20000m, null, "Tam Kart" },
                    { 4, 2, 10m, 0m, new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9392), null, 10000m, null, "Gənc Kart" },
                    { 5, 3, 0m, 5m, new DateTime(2023, 5, 7, 15, 51, 38, 407, DateTimeKind.Local).AddTicks(9393), null, 100000m, null, "Mərkəz Kart" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 15, 44, 10, 150, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 15, 44, 10, 150, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 15, 44, 10, 150, DateTimeKind.Local).AddTicks(1809));
        }
    }
}
