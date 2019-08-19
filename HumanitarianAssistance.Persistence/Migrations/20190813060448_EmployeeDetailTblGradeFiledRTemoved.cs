using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanitarianAssistance.Persistence.Migrations
{
    public partial class EmployeeDetailTblGradeFiledRTemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "EmployeeDetail");

            migrationBuilder.DropColumn(
                name: "NoOfChildren",
                table: "EmployeeDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "EmployeeDetail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoOfChildren",
                table: "EmployeeDetail",
                nullable: true);
        }
    }
}
