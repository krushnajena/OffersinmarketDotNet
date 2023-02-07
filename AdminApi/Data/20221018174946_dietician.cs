using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class dietician : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 622, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 680, DateTimeKind.Local).AddTicks(85),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(4749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(6757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 624, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(1216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(9479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.AddColumn<int>(
                name: "HospitalMasterid",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(7670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(3886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 622, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BarcodeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(2811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 678, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 673, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 673, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 679, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 675, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 676, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 676, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 19, 45, 677, DateTimeKind.Local).AddTicks(281));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HospitalMasterid",
                table: "DieticianMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 622, DateTimeKind.Local).AddTicks(7504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(9537),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 680, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(9993),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 624, DateTimeKind.Local).AddTicks(2396),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(4796),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(79),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 622, DateTimeKind.Local).AddTicks(4608),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 682, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BarcodeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 18, 23, 6, 7, 623, DateTimeKind.Local).AddTicks(7278),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 18, 23, 19, 45, 683, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 616, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 611, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 612, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 618, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 614, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 614, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 615, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 18, 23, 6, 7, 615, DateTimeKind.Local).AddTicks(2970));
        }
    }
}
