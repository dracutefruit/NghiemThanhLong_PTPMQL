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

        public async Task<IActionResult> Edit(string id)
        {
            var student = await _context.Students.FindAsync(id);
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student std)
        {
            _context.Students.Update(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string id)
        {
            var student = await _context.Students.FindAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Student std)
        {
            _context.Students.Remove(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // public IActionResult Student()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public IActionResult Student(string FullName, string StudentCode)
        // {
        //     ViewBag.Message = "Xin chào " + FullName + " " + StudentCode;
        //     return View();
        // }
    }
}
