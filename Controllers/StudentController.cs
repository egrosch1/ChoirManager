using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChoirManager.Models;
using ChoirManager.Data;
using Microsoft.Extensions.Logging;

namespace ChoirManager.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly ChoirDbContext _context;

        public StudentController(ILogger<StudentController> logger, ChoirDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
    {
        var students = _context.Students.ToList();
        return View(students);
    }

        public IActionResult Student()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
