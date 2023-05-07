using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class relationCardTypeUserCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "UserCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 38, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 38, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 38, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 39, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 39, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 39, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 39, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 40, 46, 39, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.CreateIndex(
                name: "IX_UserCards_CardId",
                table: "UserCards",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_CardTypes_CardId",
                table: "UserCards",
                column: "CardId",
                principalTable: "CardTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_CardTypes_CardId",
                table: "UserCards");

            migrationBuilder.DropIndex(
                name: "IX_UserCards_CardId",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "UserCards");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(6078));
        }
    }
}
