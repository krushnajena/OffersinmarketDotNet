using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(5364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 236, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 226, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 232, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 79, DateTimeKind.Local).AddTicks(932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 235, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductImages",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 224, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Carts",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(7279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 236, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 63, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 65, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 60, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 61, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 61, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 61, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 66, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 62, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 62, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 62, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 62, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 64, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 0, 48, 7, 64, DateTimeKind.Local).AddTicks(5914));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 236, DateTimeKind.Local).AddTicks(5129),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(2675),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(2539),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 226, DateTimeKind.Local).AddTicks(9000),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(3164),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(4669),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 232, DateTimeKind.Local).AddTicks(7043),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(6635),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 235, DateTimeKind.Local).AddTicks(1036),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 79, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(6828),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(5027),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 224, DateTimeKind.Local).AddTicks(4318),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 236, DateTimeKind.Local).AddTicks(7387),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(6809),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 220, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 222, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 215, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 216, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 216, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 216, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 223, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 219, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 219, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 219, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 219, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 221, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 23, 21, 13, 0, 221, DateTimeKind.Local).AddTicks(5621));
        }
    }
}
