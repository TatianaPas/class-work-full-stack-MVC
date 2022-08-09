using Microsoft.AspNetCore.Mvc;
using W3Class.Models;

namespace W3Class.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Display()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeId=1001, Name="Tatiana Pasechnik", Username="TaPas", Password="123456T"},
                new Employee { EmployeeId = 1002, Name = "Victor Johnston", Username = "VcJ123", Password = "444578VJ" },
                new Employee { EmployeeId = 1003, Name = "Margaret Shith", Username = "MS10245", Password = "MS10245" },
                new Employee { EmployeeId = 1004, Name = "John Wilson", Username = "JohnW", Password = "Wilson01"},
                new Employee { EmployeeId = 1005, Name = "Lisa Monroe", Username = "LisaMonroe", Password = "Lisa12345"}
            };

            
            return View(employees);
        }
    }
}
