using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fixUserCardOrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "UserCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 48, 10, 734, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.CreateIndex(
                name: "IX_UserCards_OrderId",
                table: "UserCards",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_Orders_OrderId",
                table: "UserCards",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_Orders_OrderId",
                table: "UserCards");

            migrationBuilder.DropIndex(
                name: "IX_UserCards_OrderId",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "UserCards");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 9, 12, 10, 44, 22, DateTimeKind.Local).AddTicks(9237));
        }
    }
}
