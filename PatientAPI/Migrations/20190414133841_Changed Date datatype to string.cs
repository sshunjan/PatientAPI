using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientAPI.Migrations
{
    public partial class ChangedDatedatatypetostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "PatientDetails",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "PatientDetails",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
