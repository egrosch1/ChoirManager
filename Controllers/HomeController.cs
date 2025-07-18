using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChoirManager.Models;

namespace ChoirManager.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Attendance() 
    {
        return View();
    } 

    public IActionResult Solos() 
    {
        return View();
    } 
    public IActionResult MassPrep() 
    {
        return View();
    } 
     public IActionResult RehearsalPrep() 
    {
        return View();
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
