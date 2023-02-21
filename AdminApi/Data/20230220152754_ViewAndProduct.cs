using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class ViewAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Stores_StoreId",
                table: "Followers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(6258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 260, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 257, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 549, DateTimeKind.Local).AddTicks(9707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 255, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(3566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(8486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 261, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 260, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 557, DateTimeKind.Local).AddTicks(249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 261, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(1596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(5533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(6720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(8963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(nullable: false),
                    ProductCode = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    SecondaryCategoryId = table.Column<int>(nullable: false),
                    TernaryCategoryId = table.Column<int>(nullable: false),
                    MRP = table.Column<double>(nullable: true),
                    SellingPrice = table.Column<double>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 557, DateTimeKind.Local).AddTicks(8125)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ViewCounts",
                columns: table => new
                {
                    ViewCountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ContentType = table.Column<string>(nullable: true),
                    ContentId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 559, DateTimeKind.Local).AddTicks(2195)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewCounts", x => x.ViewCountId);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 558, DateTimeKind.Local).AddTicks(5)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    ProductSpecificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 558, DateTimeKind.Local).AddTicks(1776)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => x.ProductSpecificationId);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantPriceForTwos_StoreId",
                table: "RestaurantPriceForTwos",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantImages_StoreId",
                table: "RestaurantImages",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisines_StoreId",
                table: "RestaurantCuisines",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoreId",
                table: "Products",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductId",
                table: "ProductSpecifications",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Stores_StoreId",
                table: "Followers",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantCuisines_Stores_StoreId",
                table: "RestaurantCuisines",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantImages_Stores_StoreId",
                table: "RestaurantImages",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantPriceForTwos_Stores_StoreId",
                table: "RestaurantPriceForTwos",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Stores_StoreId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantCuisines_Stores_StoreId",
                table: "RestaurantCuisines");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantImages_Stores_StoreId",
                table: "RestaurantImages");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantPriceForTwos_Stores_StoreId",
                table: "RestaurantPriceForTwos");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "ViewCounts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantPriceForTwos_StoreId",
                table: "RestaurantPriceForTwos");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantImages_StoreId",
                table: "RestaurantImages");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantCuisines_StoreId",
                table: "RestaurantCuisines");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 260, DateTimeKind.Local).AddTicks(9645),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 257, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StoreRattings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 255, DateTimeKind.Local).AddTicks(8701),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 549, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(2645),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantPriceForTwos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 261, DateTimeKind.Local).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 260, DateTimeKind.Local).AddTicks(7771),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 556, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantCuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 261, DateTimeKind.Local).AddTicks(3173),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 557, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Followers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cuisines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(9443),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 551, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(4419),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(3405),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 547, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(7798),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 10, 10, 58, 46, 256, DateTimeKind.Local).AddTicks(6102),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 2, 20, 20, 57, 53, 550, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 249, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 251, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 245, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 247, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 247, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 247, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 252, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 253, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 249, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 249, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 249, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 249, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 250, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 2, 10, 10, 58, 46, 250, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Stores_StoreId",
                table: "Followers",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
