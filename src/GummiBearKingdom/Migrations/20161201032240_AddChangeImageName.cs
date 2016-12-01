using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBearKingdom.Migrations
{
    public partial class AddChangeImageName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                nullable: true);
        }
    }
}
