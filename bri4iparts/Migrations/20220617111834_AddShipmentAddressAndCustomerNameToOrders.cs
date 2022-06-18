using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bri4iparts.Migrations
{
    public partial class AddShipmentAddressAndCustomerNameToOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShipmentAddress",
                table: "Orders",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "41d18d4b-8234-46f3-99e5-8f8a59e49c34" },
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 42, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "5f398b2d-0efb-488d-aab7-a85a52f86a8a" },
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 42, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "bb76e669-683a-46c8-b476-b612454880f9" },
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 42, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "41d18d4b-8234-46f3-99e5-8f8a59e49c34",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 42, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5f398b2d-0efb-488d-aab7-a85a52f86a8a",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 42, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "bb76e669-683a-46c8-b476-b612454880f9",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 42, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "VehicleBrandModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "VehicleBrandModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 17, 14, 18, 34, 41, DateTimeKind.Local).AddTicks(3110));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipmentAddress",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "41d18d4b-8234-46f3-99e5-8f8a59e49c34" },
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "5f398b2d-0efb-488d-aab7-a85a52f86a8a" },
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "bb76e669-683a-46c8-b476-b612454880f9" },
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "41d18d4b-8234-46f3-99e5-8f8a59e49c34",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5f398b2d-0efb-488d-aab7-a85a52f86a8a",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "bb76e669-683a-46c8-b476-b612454880f9",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "ProductManufacturers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "VehicleBrandModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "VehicleBrandModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "VehicleModifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedOn_18118039",
                value: new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5165));
        }
    }
}
