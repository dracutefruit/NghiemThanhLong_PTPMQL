using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    { 
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
