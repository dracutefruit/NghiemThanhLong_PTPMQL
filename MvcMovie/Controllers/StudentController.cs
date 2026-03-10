using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers
{
    public class StudentController(ApplicationDbContext context) : Controller
    { 
        private readonly ApplicationDbContext _context = context;

        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();
            return View(students);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student Std)
        {
            _context.Students.Add(Std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //
        public IActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Student(string FullName, string StudentCode)
        {
            ViewBag.Message = "Xin chào " + FullName + " " + StudentCode;
            return View();
        }
    }
}
