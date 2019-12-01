using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayWithDb.Migrations
{
    public partial class SalaryColumnDataTypeToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "EmployeeTable",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "EmployeeTable",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
