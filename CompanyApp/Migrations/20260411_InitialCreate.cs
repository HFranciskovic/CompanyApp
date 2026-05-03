using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace CompanyApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartmentName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    DepartmentLocation = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentNo);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LoginUserName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LoginPassword = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.LoginNo);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Salary = table.Column<int>(type: "INTEGER", nullable: false),
                    LastModifyDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DepartmentNo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeNo);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentNo",
                        column: x => x.DepartmentNo,
                        principalTable: "Departments",
                        principalColumn: "DepartmentNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginNo", "LoginPassword", "LoginUserName" },
                values: new object[,]
                {
                    { 1, "itsNotSoft", "Bill" },
                    { 2, "trollsRule", "Jean" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentNo", "DepartmentName", "DepartmentLocation" },
                values: new object[,]
                {
                    { 1, "Development", "London" },
                    { 2, "Development", "Zurich" },
                    { 3, "Sales", "Osijek" },
                    { 4, "Sales", "Zurich" },
                    { 5, "Sales", "London" },
                    { 6, "Sales", "Basel" },
                    { 7, "Sales", "Osijek" },
                    { 8, "Sales", "Lugano" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeNo", "DepartmentNo", "EmployeeName", "LastModifyDate", "Salary" },
                values: new object[,]
                {
                    { 1, 4, "Fred Davies",    new DateTime(2026, 1, 1), 50000 },
                    { 2, 3, "Bernard Katic",  new DateTime(2026, 1, 1), 50000 },
                    { 3, 5, "Rich Davies",    new DateTime(2026, 1, 1), 30000 },
                    { 4, 6, "Eva Dobos",      new DateTime(2026, 1, 1), 30000 },
                    { 5, 8, "Mario Hurnjadi", new DateTime(2026, 1, 1), 25000 },
                    { 6, 7, "Jean Michele",   new DateTime(2026, 1, 1), 25000 },
                    { 7, 2, "Bill Gates",     new DateTime(2026, 1, 1), 25000 },
                    { 8, 3, "Maja Janic",     new DateTime(2026, 1, 1), 30000 },
                    { 9, 3, "Igor Horvat",    new DateTime(2026, 1, 1), 35000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentNo",
                table: "Employees",
                column: "DepartmentNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Employees");
            migrationBuilder.DropTable(name: "Departments");
            migrationBuilder.DropTable(name: "Logins");
        }
    }
}
