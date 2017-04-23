using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FisherLink.Data.Migrations
{
    public partial class ColumnLat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lng",
                table: "Course",
                newName: "Lng");

            migrationBuilder.RenameColumn(
                name: "lat",
                table: "Course",
                newName: "Lat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lng",
                table: "Course",
                newName: "lng");

            migrationBuilder.RenameColumn(
                name: "Lat",
                table: "Course",
                newName: "lat");
        }
    }
}
