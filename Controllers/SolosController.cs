using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChoirManager.Models;

namespace ChoirManager.Controllers;

public class SolosController(ILogger<SolosController> logger) : Controller
{
    private readonly ILogger<SolosController> _logger = logger;

    public IActionResult Solos() 
    {
        return View();
    } 
     


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
