using Microsoft.AspNetCore.Mvc;
using MyFirstProject_AppWeb_Net.Data;
using MyFirstProject_AppWeb_Net.Models;

namespace MyFirstProject_AppWeb_Net.Controllers
{
    public class EmployeeController : Controller
    {
        //==============================================DATABASE===========================================
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        //==============================================END DATABASE===========================================

        //==============================================DEFAULT PAGE===========================================
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
        //==============================================END DEFAULT PAGE===========================================

        //==============================================CREATE===========================================
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        //==============================================END CREATE===========================================

        //==============================================UPDATE===========================================
        [HttpGet]
        public IActionResult Update(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        //==============================================END UPDATE===========================================

        //==============================================DELETE===========================================
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        //==============================================END DELETE===========================================
    }
}