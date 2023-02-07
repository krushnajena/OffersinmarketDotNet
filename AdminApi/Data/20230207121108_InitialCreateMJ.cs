using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class InitialCreateMJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 246, DateTimeKind.Local).AddTicks(2783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(4372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(2680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 246, DateTimeKind.Local).AddTicks(1146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(6027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(7678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 988, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(9411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(7652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 241, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 235, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 237, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 239, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 239, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 240, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 41, 8, 240, DateTimeKind.Local).AddTicks(2387));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(7927),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 246, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(5674),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(9229),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(6252),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 246, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(874),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 988, DateTimeKind.Local).AddTicks(4352),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 242, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(4490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(2833),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 41, 8, 245, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 984, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 978, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 981, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 985, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 982, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 982, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 983, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 29, 27, 983, DateTimeKind.Local).AddTicks(6418));
        }
    }
}
