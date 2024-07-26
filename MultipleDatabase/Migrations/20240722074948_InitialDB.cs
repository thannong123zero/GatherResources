using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MultipleDatabase.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_Mall",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameVN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Mall", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_Parking",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MallID = table.Column<int>(type: "int", nullable: false),
                    NameEN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameVN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Parking", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_ParkingHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MallID = table.Column<int>(type: "int", nullable: false),
                    ParkingID = table.Column<int>(type: "int", nullable: true),
                    EntryEmployee = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExitEmployee = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VisitorName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CardNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CardCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegisterdLicensePlate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntryLicensePlate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExitLicensePlate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntryTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExitTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VehicleTypeID = table.Column<int>(type: "int", nullable: false),
                    TotalTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fare = table.Column<double>(type: "double", nullable: false),
                    VoucherType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VoucherCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VoucherValue = table.Column<double>(type: "double", nullable: true),
                    TotalAmount = table.Column<double>(type: "double", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_ParkingHistory", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_RegistrationType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameVN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_RegistrationType", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_Revenue",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MallID = table.Column<int>(type: "int", nullable: false),
                    ParkingID = table.Column<int>(type: "int", nullable: true),
                    VihicleTypeID = table.Column<int>(type: "int", nullable: false),
                    RegistrationTypeID = table.Column<int>(type: "int", nullable: false),
                    CashAmount = table.Column<double>(type: "double", nullable: false),
                    VoucherValue = table.Column<double>(type: "double", nullable: false),
                    AccessTimes = table.Column<int>(type: "int", nullable: false),
                    NumberOfVourcher = table.Column<int>(type: "int", nullable: false),
                    LostCardFee = table.Column<double>(type: "double", nullable: false),
                    Revenue = table.Column<double>(type: "double", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Revenue", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_VehicleType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameVN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_VehicleType", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_Voucher",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VoucherTypeID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsUsed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Voucher", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Table_VoucherType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameVN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_VoucherType", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Table_Mall",
                columns: new[] { "ID", "CreatedBy", "CreatedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "NameEN", "NameVN" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(1835), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(1845), "Thiso Sala Center", "Trung Tâm Thiso Sala" },
                    { 2, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(1848), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(1848), "Thiso Mall Phan Van Tri", "Thiso Mall Phan Văn Trị" },
                    { 3, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(1849), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(1850), "Thiso Mall Truong Chinh - Phan Huy Ich", "Thiso Mall Trường Chinh - Phan Huy Ích" }
                });

            migrationBuilder.InsertData(
                table: "Table_RegistrationType",
                columns: new[] { "ID", "NameEN", "NameVN" },
                values: new object[,]
                {
                    { 1, "Member", "Thành Viên" },
                    { 2, "Member", "Thành Viên" },
                    { 3, "Visitor", "Khách Vãng Lai" }
                });

            migrationBuilder.InsertData(
                table: "Table_VehicleType",
                columns: new[] { "ID", "CreatedBy", "CreatedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "NameEN", "NameVN" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(9465), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(9468), "Car", "Ô tô" },
                    { 2, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(9470), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(9470), "Motorbike", "Xe máy" },
                    { 3, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(9471), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 456, DateTimeKind.Local).AddTicks(9471), "Bicycle", "Xe đạp" }
                });

            migrationBuilder.InsertData(
                table: "Table_VoucherType",
                columns: new[] { "ID", "CreatedBy", "CreatedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "NameEN", "NameVN" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 7, 22, 14, 49, 47, 457, DateTimeKind.Local).AddTicks(1951), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 457, DateTimeKind.Local).AddTicks(1954), "Emart", "Emart" },
                    { 2, null, new DateTime(2024, 7, 22, 14, 49, 47, 457, DateTimeKind.Local).AddTicks(1956), true, false, null, new DateTime(2024, 7, 22, 14, 49, 47, 457, DateTimeKind.Local).AddTicks(1956), "Thisky Hall", "Thisky Hall" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_Mall");

            migrationBuilder.DropTable(
                name: "Table_Parking");

            migrationBuilder.DropTable(
                name: "Table_ParkingHistory");

            migrationBuilder.DropTable(
                name: "Table_RegistrationType");

            migrationBuilder.DropTable(
                name: "Table_Revenue");

            migrationBuilder.DropTable(
                name: "Table_VehicleType");

            migrationBuilder.DropTable(
                name: "Table_Voucher");

            migrationBuilder.DropTable(
                name: "Table_VoucherType");
        }
    }
}
