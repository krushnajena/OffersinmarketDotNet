using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class ViewAndProducStt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 456, DateTimeKind.Local).AddTicks(695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 559, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.AddColumn<int>(
                name: "StoryView",
                table: "Stories",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(4964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(1770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 549, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(2635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 452, DateTimeKind.Local).AddTicks(5669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 557, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(6133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 558, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(1987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 557, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.AddColumn<int>(
                name: "ProductView",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductImages",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(3832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 558, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(3791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(3073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(8311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(1301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(9449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(7270));

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

            migrationBuilder.CreateIndex(
                name: "IX_Stories_StoreId",
                table: "Stories",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Stores_StoreId",
                table: "Stories",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Stores_StoreId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Stories_StoreId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "StoryView",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "ProductView",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 559, DateTimeKind.Local).AddTicks(2195),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 456, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(6258),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 549, DateTimeKind.Local).AddTicks(9707),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(3566),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(8486),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 452, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 557, DateTimeKind.Local).AddTicks(249),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 453, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 558, DateTimeKind.Local).AddTicks(1776),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 557, DateTimeKind.Local).AddTicks(8125),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 558, DateTimeKind.Local).AddTicks(5),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 454, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(1596),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(731),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(5533),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(6720),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 444, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(8963),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 448, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 22, 23, 57, 20, 447, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 544, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 546, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 540, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 541, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 541, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 541, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 543, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 543, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 543, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 543, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 545, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 20, 20, 57, 53, 545, DateTimeKind.Local).AddTicks(1039));
        }
    }
}
