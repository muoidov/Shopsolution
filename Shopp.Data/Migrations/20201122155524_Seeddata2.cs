using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopp.Data.Migrations
{
    public partial class Seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SeoDescription", "SeoTitle" },
                values: new object[] { "The shirt products for men", "The shirt products for men" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nữ", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang women" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Women Shirt", "The shirt products for women", "The shirt products for women" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN",
                column: "Name",
                value: "Tiếng Việt");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "ao-so-mi-nam-trang-viet-tien", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", 1, "viet-tien-men-t-shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 22, 22, 55, 23, 668, DateTimeKind.Local).AddTicks(8284));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo Nam", "Áo mặc cho nam", "Áo mặc cho nam" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SeoDescription", "SeoTitle" },
                values: new object[] { "The shirt of man", "The shirt of man" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo Nữ", "Áo mặc cho nữ", "Áo mặc cho nữ" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "women Shirt", "The shirt of woman", "The shirt of woman" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN",
                column: "Name",
                value: "Tieng Viet");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { null, "Áo nam cộc tay", "Áo Nam cộc tay ", "ao-nam-coc-tay", "Áo mặc cho nam cộc tay", "Áo mặc cho nam cộc tay" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { null, "The T-Shirt of man", "Men T-Shirt", 2, "men-Tshirt", "The T-shirt of man", "The T-shirt of man" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 22, 22, 48, 53, 460, DateTimeKind.Local).AddTicks(5469));
        }
    }
}
