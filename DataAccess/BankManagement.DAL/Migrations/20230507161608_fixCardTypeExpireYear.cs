using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fixCardTypeExpireYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpireYear",
                table: "CardTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExpireYear" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(4134), 3 });

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ExpireYear" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(4138), 5 });

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ExpireYear" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(4140), 3 });

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ExpireYear" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(4143), 5 });

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ExpireYear" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 16, 7, 904, DateTimeKind.Local).AddTicks(4145), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpireYear",
                table: "CardTypes");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 12, 15, 974, DateTimeKind.Local).AddTicks(4240));
        }
    }
}
