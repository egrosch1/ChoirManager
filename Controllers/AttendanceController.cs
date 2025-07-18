using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChoirManager.Models;

namespace ChoirManager.Controllers;

public class AttendanceController(ILogger<AttendanceController> logger) : Controller
{
    private readonly ILogger<AttendanceController> _logger = logger;

    public IActionResult Attendance() 
    {
        return View();
    } 
     


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
