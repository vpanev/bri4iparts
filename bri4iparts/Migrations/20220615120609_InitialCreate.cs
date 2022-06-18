using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bri4iparts.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "logs_18118039",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Command = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Table = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs_18118039", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductManufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductManufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Customers_UserId",
                        column: x => x.UserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Customers_UserId",
                        column: x => x.UserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Customers_UserId",
                        column: x => x.UserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Customers_UserId",
                        column: x => x.UserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBrands_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrandModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleBrandId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrandModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBrandModels_VehicleBrands_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleBrandId = table.Column<int>(type: "int", nullable: false),
                    VehicleBrandModelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    YearOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YearOfEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModels_VehicleBrandModels_VehicleBrandModelId",
                        column: x => x.VehicleBrandModelId,
                        principalTable: "VehicleBrandModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleModels_VehicleBrands_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrands",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleModifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false),
                    Cubature = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    Kilowats = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EngineCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YearOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YearOfEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModifications_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSubCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductManufacturerId = table.Column<int>(type: "int", nullable: false),
                    VehicleModificationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductManufacturers_ProductManufacturerId",
                        column: x => x.ProductManufacturerId,
                        principalTable: "ProductManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_VehicleModifications_VehicleModificationId",
                        column: x => x.VehicleModificationId,
                        principalTable: "VehicleModifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn_18118039 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ConcurrencyStamp", "Email", "FirstName", "LastName", "ModifiedOn_18118039", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { "41d18d4b-8234-46f3-99e5-8f8a59e49c34", "Varna, Bulgaria", "5dd9f617-acac-4a54-b89d-f0a49c84df24", "user@gmail.com", "Default", "User", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4156), "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEDR9G+s28XG5moo8a/IrN/zqBFI8gB9gHwjO8tD4eTIKaVfqtsjE4BOFy5NAPel21A==", "0876564320", "user@gmail.com" },
                    { "5f398b2d-0efb-488d-aab7-a85a52f86a8a", "Sofia, Bulgaria", "2ae5e412-2e0b-476a-87ac-3df84ab18aec", "ADMIN@gmail.com", "Admin", "User", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4172), "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKngcAGKfsb/6o5lrhWCa2ohoNEniI2IQY/vYkk7OO3TUu9dFQvNCNibW/0pW5kNKQ==", "0878000012", "admin@gmail.com" },
                    { "bb76e669-683a-46c8-b476-b612454880f9", "Pleven, Bulgaria", "5907ab1e-15b7-4b1a-a2b6-d548057e0c68", "superuser@gmail.com", "Super", "User", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4181), "SUPERUSER@GMAIL.COM", "SUPERUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEIUD4cA1MJN1pkLrRZuqIuyefwL0Fp5s84VNX24E1S7B11iyWtcl6/hko9hrsYmMRA==", "0878123413", "superuser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5289), "Спирачна система", "brakesystem.png" },
                    { 2, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5292), "Части за двигател", "engineparts.png" },
                    { 3, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5295), "Масла и течности", "oil.png" },
                    { 4, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5296), "Трансмисия", "transmission.png" },
                    { 5, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5298), "Ремъчно задвижване", "belt.png" }
                });

            migrationBuilder.InsertData(
                table: "ProductManufacturers",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5357), "Ridex", "ridex.png" },
                    { 2, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5361), "Febi Bilstein", "febibilstein.png" },
                    { 3, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5362), "VALEO", "valeo.png" },
                    { 4, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5364), "Bosch", "bosch.png" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "ModifiedOn_18118039", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "AppIdentityRole", new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(9997), "Admin", "Admin" },
                    { "2", null, "AppIdentityRole", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(24), "User", "User" },
                    { "3", null, "AppIdentityRole", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(31), "SuperUser", "SuperUser" }
                });

            migrationBuilder.InsertData(
                table: "VehicleCategories",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(4976), "Car" },
                    { 2, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5009), "Truck" },
                    { 3, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5011), "Motorcycle" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator", "ModifiedOn_18118039" },
                values: new object[,]
                {
                    { "2", "41d18d4b-8234-46f3-99e5-8f8a59e49c34", "AppIdentityUserRole", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4053) },
                    { "1", "5f398b2d-0efb-488d-aab7-a85a52f86a8a", "AppIdentityUserRole", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4041) },
                    { "3", "bb76e669-683a-46c8-b476-b612454880f9", "AppIdentityUserRole", new DateTime(2022, 6, 15, 15, 6, 9, 4, DateTimeKind.Local).AddTicks(4055) }
                });

            migrationBuilder.InsertData(
                table: "ProductSubCategories",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name", "PictureUrl", "ProductCategoryId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5314), "Накладки", "brakes.png", 1 },
                    { 2, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5317), "Спирачни дискове", "brakedisks.png", 1 },
                    { 3, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5319), "Спирачни апарати", "brakeaparats.png", 1 },
                    { 4, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5321), "Клапани", "valves.png", 2 },
                    { 5, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5323), "Разпределителен вал", "camshaft.png", 2 },
                    { 6, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5325), "Повдигачи", "lifters.png", 2 },
                    { 7, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5327), "Моторно масло", "motoroil.png", 3 },
                    { 8, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5329), "Трансмисионно масло", "transmissionoil.png", 3 },
                    { 9, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5331), "Антифриз", "antifreeze.png", 3 },
                    { 10, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5332), "Съединител", "coupler.png", 4 },
                    { 11, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5334), "Притискателен диск", "couplerdisk.png", 4 },
                    { 12, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5336), "Пистов ремък", "trackbelt.png", 5 },
                    { 13, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5338), "Комплект ангренажен ремък", "timebelt.png", 5 }
                });

            migrationBuilder.InsertData(
                table: "VehicleBrands",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name", "PictureUrl", "VehicleCategoryId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audi", "audilogo.png", 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercedes", "mercedeslogo.png", 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toyota", "toyotalogo.png", 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skoda", "skodalogo.png", 1 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MAN", "manlogo.png", 2 }
                });

            migrationBuilder.InsertData(
                table: "VehicleBrandModels",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name", "PictureUrl", "VehicleBrandId" },
                values: new object[] { 1, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5268), "Audi A3", "audia3.png", 1 });

            migrationBuilder.InsertData(
                table: "VehicleBrandModels",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name", "PictureUrl", "VehicleBrandId" },
                values: new object[] { 2, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5272), "Mercedes S-Class", "mercedessclass.png", 2 });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "ModifiedOn_18118039", "Name", "PictureUrl", "VehicleBrandId", "VehicleBrandModelId", "YearOfEnd", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5210), "Audi A3 8L1", "audia38l.png", 1, 1, new DateTime(2006, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5215), "Audi A3 8P1", "audia38p.png", 1, 1, new DateTime(2013, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5217), "Audi A3 Cabrio", "audicabrio.png", 1, 1, new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5219), "Mercedes S-class Saloon W220", "mercedesw220.png", 2, 2, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5221), "Mercedes S-class Saloon W124", "mercedesw124.png", 2, 2, new DateTime(1993, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "VehicleModifications",
                columns: new[] { "Id", "Cubature", "EngineCode", "FuelType", "HorsePower", "Kilowats", "ModifiedOn_18118039", "VehicleModelId", "YearOfEnd", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 1600, "AEH", "Gasoline", 101, 74, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5148), 1, new DateTime(2003, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1600, "AVU", "Gasoline", 102, 75, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5153), 1, new DateTime(2003, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1800, "AGN", "Gasoline", 125, 92, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5156), 1, new DateTime(2003, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1900, "AGR", "Diesel", 90, 66, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5158), 1, new DateTime(2001, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1900, "AHF", "Diesel", 110, 81, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5160), 1, new DateTime(2001, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2800, "M112.922", "Gasoline", 204, 150, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5162), 4, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3200, "OM613.960", "Diesel", 197, 145, new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5165), 4, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ModifiedOn_18118039", "Name", "PictureUrl", "Price", "ProductCategoryId", "ProductManufacturerId", "ProductSubCategoryId", "UnitsInStock", "VehicleModificationId" },
                values: new object[,]
                {
                    { 1, "накладки", new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5381), "Накладки Valeo", "valeobrakes.png", 45m, null, 3, 1, 10, 1 },
                    { 2, "моторно масло 0w30", new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5385), "Моторно масло Bosch 0w30", "boschoil.png", 75m, null, 4, 7, 10, 4 },
                    { 3, "Bosch пистов ремък", new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5388), "Пистов ремък Bosch", "boschbelt.png", 15m, null, 4, 12, 10, 4 },
                    { 4, "Съединител Valeo", new DateTime(2022, 6, 15, 15, 6, 9, 3, DateTimeKind.Local).AddTicks(5390), "Съединител Valeo", "valeocoupler.jpg", 255m, null, 3, 10, 20, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Customers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Customers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductManufacturerId",
                table: "Products",
                column: "ProductManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Products",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VehicleModificationId",
                table: "Products",
                column: "VehicleModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBrandModels_VehicleBrandId",
                table: "VehicleBrandModels",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBrands_VehicleCategoryId",
                table: "VehicleBrands",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_VehicleBrandId",
                table: "VehicleModels",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_VehicleBrandModelId",
                table: "VehicleModels",
                column: "VehicleBrandModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModifications_VehicleModelId",
                table: "VehicleModifications",
                column: "VehicleModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "logs_18118039");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductManufacturers");

            migrationBuilder.DropTable(
                name: "ProductSubCategories");

            migrationBuilder.DropTable(
                name: "VehicleModifications");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "VehicleBrandModels");

            migrationBuilder.DropTable(
                name: "VehicleBrands");

            migrationBuilder.DropTable(
                name: "VehicleCategories");
        }
    }
}
