using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class catt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 79, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Carts",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 886, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 889, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 883, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 884, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 884, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 884, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 890, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 886, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 886, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 886, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 886, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 887, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 25, 11, 6, 37, 887, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.CreateIndex(
                name: "IX_Stores_CategoryId",
                table: "Stores",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Categories_CategoryId",
                table: "Stores",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Categories_CategoryId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_CategoryId",
                table: "Stores");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ViewCounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(5364),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductSpecifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 79, DateTimeKind.Local).AddTicks(932),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 0, 48, 7, 80, DateTimeKind.Local).AddTicks(7279),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

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
    }
}
