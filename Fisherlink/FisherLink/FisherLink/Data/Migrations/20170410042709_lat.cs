using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FisherLink.Data.Migrations
{
    public partial class lat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "lat",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "lng",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lat",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "lng",
                table: "Course");
        }
    }
}
