using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 236, DateTimeKind.Local).AddTicks(5129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 456, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(2675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(2539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 226, DateTimeKind.Local).AddTicks(9000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(3164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(4669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 232, DateTimeKind.Local).AddTicks(7043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 452, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(6635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 235, DateTimeKind.Local).AddTicks(1036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(6828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductImages",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(5027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 224, DateTimeKind.Local).AddTicks(4318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(6809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 236, DateTimeKind.Local).AddTicks(7387)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 456, DateTimeKind.Local).AddTicks(695),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 236, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(733),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(4964),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(1770),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 226, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(2635),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 452, DateTimeKind.Local).AddTicks(5669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 232, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 233, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(6133),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 235, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(1987),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(3832),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 234, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(3791),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(3073),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 228, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(8311),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 224, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(1301),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(9449),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 23, 21, 13, 0, 227, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 441, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 443, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 437, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 438, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 438, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 438, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 440, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 440, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 440, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 440, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 442, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 22, 23, 57, 20, 442, DateTimeKind.Local).AddTicks(2287));
        }
    }
}
