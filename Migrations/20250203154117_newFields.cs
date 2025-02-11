using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantSalaries.Migrations
{
    /// <inheritdoc />
    public partial class newFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Employees_EmployeeId",
                table: "Salaries");

            migrationBuilder.RenameColumn(
                name: "TotalSalary",
                table: "Salaries",
                newName: "Общо Заплата");

            migrationBuilder.RenameColumn(
                name: "HoursWorked",
                table: "Salaries",
                newName: "Отработени Часове");

            migrationBuilder.RenameColumn(
                name: "HourlyRate",
                table: "Salaries",
                newName: "Почасова Ставка");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Salaries",
                newName: "СлужителId");

            migrationBuilder.RenameColumn(
                name: "Deductions",
                table: "Salaries",
                newName: "Удръжки");

            migrationBuilder.RenameColumn(
                name: "DateSalaryRecieved",
                table: "Salaries",
                newName: "Дата на получаване");

            migrationBuilder.RenameColumn(
                name: "Bonus",
                table: "Salaries",
                newName: "Бонус");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Salaries",
                newName: "Основна Заплата");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_EmployeeId",
                table: "Salaries",
                newName: "IX_Salaries_СлужителId");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Employees",
                newName: "Длъжност");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "Име");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Salaries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Бонус",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Отработени часове",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Почасова ставка",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Удръжки",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_EmployeeId1",
                table: "Salaries",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Employees_EmployeeId1",
                table: "Salaries",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Employees_СлужителId",
                table: "Salaries",
                column: "СлужителId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Employees_EmployeeId1",
                table: "Salaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Employees_СлужителId",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_Salaries_EmployeeId1",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "Бонус",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Отработени часове",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Почасова ставка",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Удръжки",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Удръжки",
                table: "Salaries",
                newName: "Deductions");

            migrationBuilder.RenameColumn(
                name: "СлужителId",
                table: "Salaries",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Почасова Ставка",
                table: "Salaries",
                newName: "HourlyRate");

            migrationBuilder.RenameColumn(
                name: "Отработени Часове",
                table: "Salaries",
                newName: "HoursWorked");

            migrationBuilder.RenameColumn(
                name: "Основна Заплата",
                table: "Salaries",
                newName: "BaseSalary");

            migrationBuilder.RenameColumn(
                name: "Общо Заплата",
                table: "Salaries",
                newName: "TotalSalary");

            migrationBuilder.RenameColumn(
                name: "Дата на получаване",
                table: "Salaries",
                newName: "DateSalaryRecieved");

            migrationBuilder.RenameColumn(
                name: "Бонус",
                table: "Salaries",
                newName: "Bonus");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_СлужителId",
                table: "Salaries",
                newName: "IX_Salaries_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Име",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Длъжност",
                table: "Employees",
                newName: "Position");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Employees_EmployeeId",
                table: "Salaries",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
