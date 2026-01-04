using EmployeeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;

namespace EmployeeMVC.Controllers
{
    public class EmployeesController : Controller
    {
        //_context = database connection object Comes from Dependency Injection
        private readonly EmployeeContext _context;

        //ASP.NET automatically gives DbContext object do not create it manually
        public EmployeesController(EmployeeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Employees.ToList();
            return View(data);
        }


        //create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        // update /edit
        public IActionResult Edit(int id)
        {
            var emp = _context.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            _context.Employees.Update(emp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //delete
        public IActionResult Delete(int id)
        {
            var emp = _context.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var emp = _context.Employees.Find(id);
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
