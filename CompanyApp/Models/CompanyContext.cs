using Microsoft.EntityFrameworkCore;

namespace CompanyApp.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Logins
            modelBuilder.Entity<Login>().HasData(
                new Login { LoginNo = 1, LoginUserName = "Bill", LoginPassword = "itsNotSoft" },
                new Login { LoginNo = 2, LoginUserName = "Jean", LoginPassword = "trollsRule" }
            );

            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentNo = 1, DepartmentName = "Development", DepartmentLocation = "London" },
                new Department { DepartmentNo = 2, DepartmentName = "Development", DepartmentLocation = "Zurich" },
                new Department { DepartmentNo = 3, DepartmentName = "Sales", DepartmentLocation = "Osijek" },
                new Department { DepartmentNo = 4, DepartmentName = "Sales", DepartmentLocation = "Zurich" },
                new Department { DepartmentNo = 5, DepartmentName = "Sales", DepartmentLocation = "London" },
                new Department { DepartmentNo = 6, DepartmentName = "Sales", DepartmentLocation = "Basel" },
                new Department { DepartmentNo = 7, DepartmentName = "Sales", DepartmentLocation = "Osijek" },
                new Department { DepartmentNo = 8, DepartmentName = "Sales", DepartmentLocation = "Lugano" }
            );

            // Seed Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeNo = 1, EmployeeName = "Fred Davies",    Salary = 50000, LastModifyDate = DateTime.Now, DepartmentNo = 4 },
                new Employee { EmployeeNo = 2, EmployeeName = "Bernard Katic",  Salary = 50000, LastModifyDate = DateTime.Now, DepartmentNo = 3 },
                new Employee { EmployeeNo = 3, EmployeeName = "Rich Davies",    Salary = 30000, LastModifyDate = DateTime.Now, DepartmentNo = 5 },
                new Employee { EmployeeNo = 4, EmployeeName = "Eva Dobos",      Salary = 30000, LastModifyDate = DateTime.Now, DepartmentNo = 6 },
                new Employee { EmployeeNo = 5, EmployeeName = "Mario Hurnjadi", Salary = 25000, LastModifyDate = DateTime.Now, DepartmentNo = 8 },
                new Employee { EmployeeNo = 6, EmployeeName = "Jean Michele",   Salary = 25000, LastModifyDate = DateTime.Now, DepartmentNo = 7 },
                new Employee { EmployeeNo = 7, EmployeeName = "Bill Gates",     Salary = 25000, LastModifyDate = DateTime.Now, DepartmentNo = 2 },
                new Employee { EmployeeNo = 8, EmployeeName = "Maja Janic",     Salary = 30000, LastModifyDate = DateTime.Now, DepartmentNo = 3 },
                new Employee { EmployeeNo = 9, EmployeeName = "Igor Horvat",    Salary = 35000, LastModifyDate = DateTime.Now, DepartmentNo = 3 }
            );
        }
    }
}
