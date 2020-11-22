using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopp.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of ShopSolution");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of ShopSolution");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of ShopSolution");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 22, 22, 48, 53, 460, DateTimeKind.Local).AddTicks(5469));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of eShopSolution");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of eShopSolution");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of eShopSolution");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 22, 22, 36, 43, 964, DateTimeKind.Local).AddTicks(1709));
        }
    }
}
