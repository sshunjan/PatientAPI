using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientAPI.Migrations
{
    public partial class Changingbacktodatedatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "PatientDetails",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "PatientDetails",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
