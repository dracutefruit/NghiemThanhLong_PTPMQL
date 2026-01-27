using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class DemoController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName)
        {
            ViewBag.Message = "Xin chào " + FullName;
            return View();
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
