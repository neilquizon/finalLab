﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace finalLab.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCarts",
                columns: table => new
                {
                    key = table.Column<string>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    geo_localarea = table.Column<string>(nullable: true),
                    longitude = table.Column<float>(nullable: false),
                    latitude = table.Column<float>(nullable: false),
                    location = table.Column<string>(nullable: true),
                    vendor_type = table.Column<string>(nullable: true),
                    business_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCarts", x => x.key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCarts");
        }
    }
}
