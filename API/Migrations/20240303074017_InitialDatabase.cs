﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuGroups",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuGroupID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuGroups_MenuGroupID",
                        column: x => x.MenuGroupID,
                        principalTable: "MenuGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuItemID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscriptionVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentVN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_MenuItems_MenuItemID",
                        column: x => x.MenuItemID,
                        principalTable: "MenuItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Units_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuGroupID",
                table: "MenuItems",
                column: "MenuGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MenuItemID",
                table: "Products",
                column: "MenuItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitID",
                table: "Products",
                column: "UnitID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "MenuGroups");
        }
    }
}
