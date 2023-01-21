using Microsoft.AspNetCore.Mvc;
using MVCday2.Models;

namespace MVCday2.Controllers
{
    public class EmployeeController : Controller
    {
        private CompanyDbContext dbContext;
        public EmployeeController()
        {
            dbContext = new CompanyDbContext();
        }

        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees.ToList();
            return View(employees);
        }

        public IActionResult GetById(int id)
        {
            Employee? employee = dbContext.Employees.SingleOrDefault(e => e.SSN == id);
            if (employee == null)
            {
                return View("Error");
            }
            return View(employee);
        }

        public IActionResult Add()
        {
            List<Employee> employees = dbContext.Employees.ToList();
            return View(employees);
        }

        public IActionResult AddEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();

            List<Employee> employees = dbContext.Employees.ToList();
            return View("Index", employees);
        }

        public IActionResult Edit(int id)
        {
            Employee employee = dbContext.Employees.SingleOrDefault(e => e.SSN == id);
            List<Employee> employees = dbContext.Employees.ToList();
            ViewBag.ins = employees;
            return View(employee);
        }

        public IActionResult Edit(Employee employee)
        {
            Employee employeee = dbContext.Employees.SingleOrDefault(e => e.SSN == employee.SSN);
            employeee.FirstName = employee.FirstName;
            employeee.LastName = employee.LastName;
            employeee.Salary = employee.Salary;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Employee employee = dbContext.Employees.SingleOrDefault(e => e.SSN == id);
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
