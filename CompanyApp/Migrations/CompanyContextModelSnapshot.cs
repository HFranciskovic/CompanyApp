using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CompanyApp.Models;

#nullable disable

namespace CompanyApp.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("CompanyApp.Models.Department", b =>
            {
                b.Property<int>("DepartmentNo").ValueGeneratedOnAdd().HasColumnType("INTEGER");
                b.Property<string>("DepartmentName").IsRequired().HasMaxLength(20).HasColumnType("TEXT");
                b.Property<string>("DepartmentLocation").IsRequired().HasMaxLength(20).HasColumnType("TEXT");
                b.HasKey("DepartmentNo");
                b.ToTable("Departments");
                b.HasData(
                    new { DepartmentNo = 1, DepartmentName = "Development", DepartmentLocation = "London" },
                    new { DepartmentNo = 2, DepartmentName = "Development", DepartmentLocation = "Zurich" },
                    new { DepartmentNo = 3, DepartmentName = "Sales", DepartmentLocation = "Osijek" },
                    new { DepartmentNo = 4, DepartmentName = "Sales", DepartmentLocation = "Zurich" },
                    new { DepartmentNo = 5, DepartmentName = "Sales", DepartmentLocation = "London" },
                    new { DepartmentNo = 6, DepartmentName = "Sales", DepartmentLocation = "Basel" },
                    new { DepartmentNo = 7, DepartmentName = "Sales", DepartmentLocation = "Osijek" },
                    new { DepartmentNo = 8, DepartmentName = "Sales", DepartmentLocation = "Lugano" });
            });

            modelBuilder.Entity("CompanyApp.Models.Employee", b =>
            {
                b.Property<int>("EmployeeNo").ValueGeneratedOnAdd().HasColumnType("INTEGER");
                b.Property<int>("DepartmentNo").HasColumnType("INTEGER");
                b.Property<string>("EmployeeName").IsRequired().HasMaxLength(50).HasColumnType("TEXT");
                b.Property<DateTime>("LastModifyDate").HasColumnType("TEXT");
                b.Property<int>("Salary").HasColumnType("INTEGER");
                b.HasKey("EmployeeNo");
                b.HasIndex("DepartmentNo");
                b.ToTable("Employees");
                b.HasData(
                    new { EmployeeNo = 1, DepartmentNo = 4, EmployeeName = "Fred Davies",    LastModifyDate = new DateTime(2026,1,1), Salary = 50000 },
                    new { EmployeeNo = 2, DepartmentNo = 3, EmployeeName = "Bernard Katic",  LastModifyDate = new DateTime(2026,1,1), Salary = 50000 },
                    new { EmployeeNo = 3, DepartmentNo = 5, EmployeeName = "Rich Davies",    LastModifyDate = new DateTime(2026,1,1), Salary = 30000 },
                    new { EmployeeNo = 4, DepartmentNo = 6, EmployeeName = "Eva Dobos",      LastModifyDate = new DateTime(2026,1,1), Salary = 30000 },
                    new { EmployeeNo = 5, DepartmentNo = 8, EmployeeName = "Mario Hurnjadi", LastModifyDate = new DateTime(2026,1,1), Salary = 25000 },
                    new { EmployeeNo = 6, DepartmentNo = 7, EmployeeName = "Jean Michele",   LastModifyDate = new DateTime(2026,1,1), Salary = 25000 },
                    new { EmployeeNo = 7, DepartmentNo = 2, EmployeeName = "Bill Gates",     LastModifyDate = new DateTime(2026,1,1), Salary = 25000 },
                    new { EmployeeNo = 8, DepartmentNo = 3, EmployeeName = "Maja Janic",     LastModifyDate = new DateTime(2026,1,1), Salary = 30000 },
                    new { EmployeeNo = 9, DepartmentNo = 3, EmployeeName = "Igor Horvat",    LastModifyDate = new DateTime(2026,1,1), Salary = 35000 });
            });

            modelBuilder.Entity("CompanyApp.Models.Login", b =>
            {
                b.Property<int>("LoginNo").ValueGeneratedOnAdd().HasColumnType("INTEGER");
                b.Property<string>("LoginPassword").IsRequired().HasMaxLength(20).HasColumnType("TEXT");
                b.Property<string>("LoginUserName").IsRequired().HasMaxLength(20).HasColumnType("TEXT");
                b.HasKey("LoginNo");
                b.ToTable("Logins");
                b.HasData(
                    new { LoginNo = 1, LoginPassword = "itsNotSoft", LoginUserName = "Bill" },
                    new { LoginNo = 2, LoginPassword = "trollsRule", LoginUserName = "Jean" });
            });

            modelBuilder.Entity("CompanyApp.Models.Employee", b =>
            {
                b.HasOne("CompanyApp.Models.Department", "Department")
                    .WithMany("Employees")
                    .HasForeignKey("DepartmentNo")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.Navigation("Department");
            });

            modelBuilder.Entity("CompanyApp.Models.Department", b =>
            {
                b.Navigation("Employees");
            });
#pragma warning restore 612, 618
        }
    }
}
