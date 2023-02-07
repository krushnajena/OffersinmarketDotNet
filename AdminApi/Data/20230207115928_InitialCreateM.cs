using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class InitialCreateM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreRattings_Stores_StoreId",
                table: "StoreRattings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(7927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 693, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(5674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 691, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(9229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 691, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(6252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 988, DateTimeKind.Local).AddTicks(4352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(4490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(2833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(4914));

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

            migrationBuilder.AddForeignKey(
                name: "FK_StoreRattings_Stores_StoreId",
                table: "StoreRattings",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreRattings_Stores_StoreId",
                table: "StoreRattings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 693, DateTimeKind.Local).AddTicks(67),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 691, DateTimeKind.Local).AddTicks(7834),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(1518),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 691, DateTimeKind.Local).AddTicks(9656),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 990, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(8383),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(3314),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(6481),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 988, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(6666),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 7, 17, 11, 5, 692, DateTimeKind.Local).AddTicks(4914),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 7, 17, 29, 27, 991, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 688, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 681, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 684, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 689, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 686, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 686, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 687, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 7, 17, 11, 5, 687, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.AddForeignKey(
                name: "FK_StoreRattings_Stores_StoreId",
                table: "StoreRattings",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
