using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class relationUserCardUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_UserCards_UserId",
                table: "UserCards",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_Users_UserId",
                table: "UserCards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_Users_UserId",
                table: "UserCards");

            migrationBuilder.DropIndex(
                name: "IX_UserCards_UserId",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserCards");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 19, 35, 45, 362, DateTimeKind.Local).AddTicks(6630));
        }
    }
}
