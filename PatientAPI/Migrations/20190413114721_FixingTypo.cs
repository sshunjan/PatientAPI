using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientAPI.Migrations
{
    public partial class FixingTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LirstName",
                table: "PatientDetails",
                newName: "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "PatientDetails",
                newName: "LirstName");
        }
    }
}
